using GestaoDDD.Domain.Entities;
using System.Collections.Generic;

namespace GestaoDDD.Application.Interface
{
  public interface IDptoPoliciaAppService : IAppServiceBase<DepartamentoPolicia>
  {
    IEnumerable<DepartamentoPolicia> CalculaDistancia(string latitudeAtual, string longitudeAtual);

    IEnumerable<DepartamentoPolicia> BuscaDelegaciasProximas(string latitudeAtual, string longitudeAtual);
  }
}
