using GestaoDDD.Application.Interface;
using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Services;

namespace GestaoDDD.Application.Services
{
    public class CandidatoAppService : AppServiceBase<Candidato>, ICandidatoAppService
    {
        private readonly ICandidatoService _candidatoService;

        public CandidatoAppService(ICandidatoService candidatoService)
            : base(candidatoService)
        {
            _candidatoService = candidatoService;
        }

        //public IEnumerable<Candidato> ObterCandidatosEspeciais()
        //{
        //    return Mapper.Map<IEnumerable<Candidato>, IEnumerable<CandidatoViewModel>>(_candidatoService.ObterCandidatosEspeciais());
        //}
    }
}
