using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Infra.Data.Contexto;

namespace GestaoDDD.Infra.Data.Repositories
{
  public class DptoPoliciaRepository : RepositoryBase<DepartamentoPolicia>, IDptoPoliciaRepository
  {
    private readonly GestaoContext _db;
    public DptoPoliciaRepository(GestaoContext dbContext)
        : base(dbContext)
    {
      //nao ppode ser new gestaocontext para nao instanciar novamente o contexto
      _db = dbContext;
    }
  }
}
