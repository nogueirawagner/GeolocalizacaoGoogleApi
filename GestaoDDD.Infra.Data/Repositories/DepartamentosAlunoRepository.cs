using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Estatics.TypesPatterns;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Infra.Data.Contexto;
using System.Collections.Generic;
using System.Linq;


namespace GestaoDDD.Infra.Data.Repositories
{
  public class DptoAlunoRepository : RepositoryBase<DepartamentoAluno>, IDptoAlunoRepository
  {
    private readonly GestaoContext _db;
    private readonly IDptoPoliciaRepository _dptoPoliciaRepository;
    public DptoAlunoRepository(GestaoContext dbContext, IDptoPoliciaRepository dptoPoliciaRepository)
        : base(dbContext)
    {
      //nao ppode ser new gestaocontext para nao instanciar novamente o contexto
      _db = dbContext;
      _dptoPoliciaRepository = dptoPoliciaRepository;
    }

    public bool AlunoJaEscolheuUnidade(int pAlunoID, int pDptoPoliciaID)
    {
      return _db.DepartamentoAluno.Any(s => s.AlunoID == pAlunoID && s.DptoID == pDptoPoliciaID);
    }

    public IEnumerable<DepartamentoPolicia> PegaDptosPreferenciaAluno(int pAlunoID)
    {
      return (from da in _db.Set<DepartamentoAluno>()
              join dp in _db.Set<DepartamentoPolicia>()
              on da.DptoID equals dp.ID
              where da.AlunoID == pAlunoID
              select dp).ToList();
    }

    public IEnumerable<XDepartamentoPreferenciaAluno> PegarDptoContempladosAluno(int pAlunoId)
    {
      var sql = @"
        WITH PessoasConcorreramVagas AS (
        select 
	        a.ID AlunoId, 
	        (a.NotaEtapa1 + a.NotaEtapa2) Nota, 
	        dp.ID DpId,
	        a.Concorrencia,
	        SUM(1) over (partition by a.concorrencia, dp.ID order by (a.NotaEtapa1 + a.NotaEtapa2) desc) Posicao
        from DepartamentoPolicia dp
	        join DepartamentoAluno da on da.DptoID = dp.ID
	        join Aluno a on a.ID = da.AlunoID
        group by a.ID, a.Concorrencia, a.NotaEtapa1, a.NotaEtapa2, dp.ID
        )

        select 
	        a.ID AlunoId, 
	        dp.Vagas QtdVagas,
          dp.EhSede,
          dp.Bairro,
          dp.ID DepartamentoId,
	        dp.Nome Nome,
	        (case
		        WHEN dp.Vagas < pcv.Posicao THEN 'Não' ELSE 'Sim'
	        end) Contemplada
        from PessoasConcorreramVagas pcv
	        join Aluno a on a.ID = pcv.AlunoId
	        join DepartamentoPolicia dp on dp.Id = pcv.DpId
        where a.ID = {0}";

      sql = string.Format(sql, pAlunoId);

      return _db.Database.SqlQuery<XDepartamentoPreferenciaAluno>(sql);
    }

    public DepartamentoAluno PegarDptoPreferenciaPorAluno(int pAlunoId, int pDptoPoliciaId)
    {
      return (from da in _db.Set<DepartamentoAluno>()
              where da.AlunoID == pAlunoId && da.DptoID == pDptoPoliciaId
              select da).FirstOrDefault();
    }

    public IEnumerable<XGraficoDepartamentosAlunos> PegarGraficoDptosAlunos()
    {
      var resultado = _db.Set<DepartamentoAluno>()
                  .Join(_db.Set<DepartamentoPolicia>(),
                    da => da.DptoID,
                    dp => dp.ID,
                    (da, dp) => new { DepartamentoAluno = da, DepartamentoPolicia = dp })
                  .GroupBy(joined => new { joined.DepartamentoPolicia.Nome, joined.DepartamentoPolicia.Vagas })
                  .Select(g => new XGraficoDepartamentosAlunos
                  {
                    Nome = g.Key.Nome,
                    Vagas = g.Key.Vagas,
                    Pessoas = g.Count()
                  })
                  .OrderByDescending(s => s.Pessoas)
                  .ToList(); // Convertendo para uma lista IEnumerable

      return resultado;
    }

    public IEnumerable<XPreferenciasRISP> PegarPreferenciaAlunosPorRegioes()
    {
      var sql = @"
        WITH PessoasRegiao AS (
	      select 
		      rs.Nome,
		      a.Nome NomeAluno
	      from DepartamentoPolicia dp
		      join DepartamentoAluno da on da.DptoID = dp.ID
		      join Aluno a on a.ID = da.AlunoID
		      join DepartamentoRISP dpr on dpr.DptoId = dp.ID
		      join RegioesSeguranca rs on rs.ID = dpr.RispId
	      group by rs.Nome, a.Nome
      )

      , AgrupandoDados AS (
				select Nome, COUNT(*) QtdPessoas from PessoasRegiao pr
				group by Nome
			)
			select * from AgrupandoDados order by QtdPessoas desc
";

      return _db.Database.SqlQuery<XPreferenciasRISP>(sql);
    }

    public IEnumerable<XPreferenciasBairro> PegarPreferenciaAlunosPorBairros()
    {
      var sql = @"
       WITH PreferenciasPorBairrosAgente AS (
	      select 
		      dp.Bairro,
		      a.Cargo
	      from DepartamentoPolicia dp
		      join DepartamentoAluno da on da.DptoID = dp.ID
		      join Aluno a on a.ID = da.AlunoID
	      where a.Cargo = 'Agente'
      )
		
      ,  PreferenciasPorBairrosEscrivao AS (
	      select 
		      dp.Bairro,
		      a.Cargo
	      from DepartamentoPolicia dp
		      join DepartamentoAluno da on da.DptoID = dp.ID
		      join Aluno a on a.ID = da.AlunoID
	      where a.Cargo = 'Escrivao'
      )

      , BairrosEscolhidosCargos AS (
	      select Bairro from PreferenciasPorBairrosAgente
	      union all
	      select Bairro from PreferenciasPorBairrosEscrivao 
      )

      , BairrosEscolhidos AS (
	      select * from BairrosEscolhidosCargos 
	      group by Bairro
      )

      , PessoasBairrosAgente AS (
	      select 
		      (CASE
			      when CHARINDEX('Nucleo Bandeirante', Bairro) <> 0 then 'N. Bandeirante' 
			      when CHARINDEX('Recanto das Emas', Bairro) <> 0 then 'R. Emas' 
			      else 
			      Bairro
		      END) Bairro,
		      COUNT(*) QtdAgente
	      from PreferenciasPorBairrosAgente
	      group by Bairro
      )

      , PessoasBairrosEscrivao AS (
	      select 
		      (CASE
			      when CHARINDEX('Nucleo Bandeirante', Bairro) <> 0 then 'N. Bandeirante' 
			      when CHARINDEX('Recanto das Emas', Bairro) <> 0 then 'R. Emas' 
			      else 
			      Bairro
		      END) Bairro,
		      COUNT(*) QtdEscrivao
	      from PreferenciasPorBairrosEscrivao
	      group by Bairro
      )

      select 
	      br.Bairro, 
	      COALESCE(pa.QtdAgente, 0) QtdAgente,
	      COALESCE(pe.QtdEscrivao, 0) QtdEscrivao
      from BairrosEscolhidos br
      left join PessoasBairrosAgente pa on pa.Bairro = br.Bairro
      left join PessoasBairrosEscrivao pe on pe.Bairro = br.Bairro

";

      return _db.Database.SqlQuery<XPreferenciasBairro>(sql);
    }
  }
}
