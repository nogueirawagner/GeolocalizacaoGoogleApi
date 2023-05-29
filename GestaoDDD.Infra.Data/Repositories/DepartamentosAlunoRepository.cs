using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Infra.Data.Contexto;

namespace GestaoDDD.Infra.Data.Repositories
{
  public class DptoAlunoRepository : RepositoryBase<DepartamentoAluno>, IDptoAlunoRepository
  {
    private readonly GestaoContext _db;
    public DptoAlunoRepository(GestaoContext dbContext)
        : base(dbContext)
    {
      //nao ppode ser new gestaocontext para nao instanciar novamente o contexto
      _db = dbContext;
    }
  }
}
