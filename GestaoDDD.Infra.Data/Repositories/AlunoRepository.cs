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
      //nao ppode ser new gestaocontext para nao instanciar novamente o contexto
      _db = dbContext;
    }
  }
}
