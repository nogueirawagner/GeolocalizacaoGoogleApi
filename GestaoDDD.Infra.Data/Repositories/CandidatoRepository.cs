using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Infra.Data.Contexto;

namespace GestaoDDD.Infra.Data.Repositories
{
    public class CandidatoRepository : RepositoryBase<Candidato>, ICandidatoRepository
    {
        private readonly GestaoContext _db;
        public CandidatoRepository(GestaoContext dbContext)
            : base(dbContext)
        {
            //nao ppode ser new gestaocontext para nao instanciar novamente o contexto
            _db = dbContext;
        }

        //retorna todas as cetegorias especias
        //public string retorna(string id, int numero)
        //{
        //    return consulta
        //}
    }
}
