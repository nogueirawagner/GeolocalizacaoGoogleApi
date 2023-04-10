using GestaoDDD.Domain.Entities;
using System.Collections.Generic;

namespace GestaoDDD.Application.Interface
{
  public interface ICandidatoAppService : IAppServiceBase<Candidato>
  {
    IEnumerable<Candidato> CalculaDistancia(string latitudeAtual, string longitudeAtual);

    IEnumerable<Candidato> BuscaCandidatosProximos(string latitudeAtual, string longitudeAtual);
  }
}
