using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Estatics;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDDD.Infra.Data.Repositories
{
  public class AlunoRepository : RepositoryBase<Aluno>, IAlunoRepository
  {
    private readonly GestaoContext _db;

    public AlunoRepository(GestaoContext dbContext)
        : base(dbContext)
    {
      _db = dbContext;
    }

    public void AtualizarNotaCFP(int pAlunoId, double pNota)
    {
      var aluno = GetById(pAlunoId);
      aluno.NotaEtapa2 = pNota;
      aluno.NotaFinalProvisoria = aluno.NotaEtapa1 + pNota;
      Update(aluno);
      Task.Run(() => Task.FromResult(AtualizarRankingAluno(aluno.Concorrencia)));
    }

    private Task<int> AtualizarRankingAluno(string pConcorrencia)
    {
      using (var db = new GestaoContext())
      {
        var sql = string.Format(@"update Aluno set PosicaoProvisoria = 0 where Cargo = 'Agente' and Concorrencia = '{0}'", pConcorrencia);
        db.Database.ExecuteSqlCommand(sql);

        var sqlAtualiza = string.Format(@"

            WITH AtualizarRank AS (

            select 
            ID, Nome,
            ROW_NUMBER ( )   
                OVER ( order by NotaFinalProvisoria desc )  PosicaoProvisoria

            from Aluno where Cargo = 'Agente'
            and Concorrencia = '{0}'
            )

            update a set a.PosicaoProvisoria = ar.PosicaoProvisoria from Aluno a
            join AtualizarRank ar on ar.ID = a.ID
        ", pConcorrencia);

        return Task.FromResult(db.Database.ExecuteSqlCommand(sqlAtualiza));
      }
    }

    public IEnumerable<Aluno> PesquisarAlunosPorPalavras(string pTermo, string pConcorrencia, string pCargo)
    {
      var pChaves = new List<string>();
      var where = XFullText.MontarCondicao(pTermo, "Nome", out pChaves);

      //var sql = @"SELECT * FROM Aluno WHERE {0} and Concorrencia = '{1}' and Cargo = '{2}' ORDER BY Posicao";
      var sql = @"SELECT * FROM Aluno WHERE {0} and Concorrencia = '{1}' and Cargo = '{2}' ORDER BY PosicaoProvisoria";

      sql = string.Format(sql, where, pConcorrencia, pCargo);
      return _db.Database.SqlQuery<Aluno>(sql);
    }

    public string PegarMediaCalculada()
    {
      var sql = @"select 
	        CAST(AVG(NotaEtapa2) as numeric(18,2)) Media 
        from Aluno 
        where Cargo = 'Agente' 
	        and NotaFinalProvisoria > 0
	        and NotaEtapa2 <> 43.25
	        and NotaEtapa2 > 0
        ";

      var media = _db.Database.SqlQuery<decimal>(sql).FirstOrDefault();
      return string.Format("Média: {0}", media);
    }

    public IEnumerable<Aluno> PegarAlunosPorCargoConcorrencia(string pCargo, string pConcorrencia)
    {
      //var sql = @"SELECT * FROM Aluno WHERE Concorrencia = '{0}' and Cargo = '{1}' ORDER BY Posicao";
      var sql = @"SELECT * FROM Aluno WHERE Concorrencia = '{0}' and Cargo = '{1}' ORDER BY PosicaoProvisoria";

      sql = string.Format(sql, pConcorrencia, pCargo);

      return _db.Database.SqlQuery<Aluno>(sql);
    }
  }
}
