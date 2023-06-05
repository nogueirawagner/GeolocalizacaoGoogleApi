using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Infra.Data.Contexto;

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
      Update(aluno);
    }
  }
}
