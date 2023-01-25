using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Domain.Interfaces.Services;

namespace GestaoDDD.Domain.Services
{
  public class CandidatoService : ServiceBase<Candidato>, ICandidatoService
  {

    private readonly ICandidatoRepository _candidatoRepository;

    public CandidatoService(ICandidatoRepository candidatorepository)
    : base(candidatorepository)
    {
      _candidatoRepository = candidatorepository;
    }
  }
}
