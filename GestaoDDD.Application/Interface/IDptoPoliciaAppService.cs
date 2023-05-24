using GestaoDDD.Domain.Entities;
using System.Collections.Generic;

namespace GestaoDDD.Application.Interface
{
  public interface IDptoPoliciaAppService : IAppServiceBase<DepartamentoPolicia>
  {
    IEnumerable<DepartamentoPolicia> CalculaDistancia(string latitudeAtual, string longitudeAtual);

    //IEnumerable<Candidato> BuscaCandidatosProximos(string latitudeAtual, string longitudeAtual);
  }
}
