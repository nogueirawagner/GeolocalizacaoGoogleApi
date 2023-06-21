using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Estatics;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;

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
      aluno.NotaFinal = aluno.NotaEtapa1 + pNota;
      Update(aluno);
    }

    public IEnumerable<Aluno> PesquisarAlunosPorPalavras(string pTermo, string pConcorrencia)
    {
      var pChaves = new List<string>();
      var where = XFullText.MontarCondicao(pTermo, "Nome", out pChaves);
      
      var sql = @"SELECT * FROM Aluno WHERE {0} and Concorrencia = '{1}'";
      var sqlLike = @"SELECT * FROM Aluno WHERE Nome LIKE '%{0}%' and Concorrencia = '{1}'";

      sql = string.Format(sqlLike, pTermo, pConcorrencia);


      return _db.Database.SqlQuery<Aluno>(sql);
    }
  }
}
