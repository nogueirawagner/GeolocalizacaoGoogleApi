using AutoMapper;
using GeoCoordinatePortable;
using GestaoDDD.Application.Interface;
using GestaoDDD.Application.ViewModels;
using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace GestaoDDD.Application.Services
{
  public class DptoPoliciaAppService : AppServiceBase<DepartamentoPolicia>, IDptoPoliciaAppService
  {
    private readonly IDptoPoliciaService _dptoPoliciaService;

    public DptoPoliciaAppService(IDptoPoliciaService dptoPoliciaService)
        : base(dptoPoliciaService)
    {
      _dptoPoliciaService = dptoPoliciaService;
    }

    public IEnumerable<DepartamentoPolicia> BuscaDelegaciasProximas(string latitudeAtual, string longitudeAtual)
    {
      var dptosProximos = new List<DepartamentoPolicia>();

      var coordAtual = new GeoCoordinate();
      coordAtual.Latitude = double.Parse(latitudeAtual.Replace(",", "."),
            CultureInfo.InvariantCulture);
      coordAtual.Longitude = double.Parse(longitudeAtual.Replace(",", "."),
            CultureInfo.InvariantCulture);

      var candidatos = _dptoPoliciaService.GetAll();

      foreach (var cand in candidatos)
      {
        var coordCandidato = new GeoCoordinate();

        if (!string.IsNullOrEmpty(cand.Latitude) || !string.IsNullOrEmpty(cand.Longitude))
        {
          coordCandidato.Latitude = double.Parse(cand.Latitude.Replace(",", "."),
              CultureInfo.InvariantCulture);
          coordCandidato.Longitude = double.Parse(cand.Longitude.Replace(",", "."),
                CultureInfo.InvariantCulture);

          var distancia = (coordAtual.GetDistanceTo(coordCandidato) / 1000);

          if (Math.Round(distancia, 2) <= 10)
          {
            cand.DistanciaColega =
              string.Format("{0} está a {1} km", cand.Nome.Trim(), Math.Round(distancia, 2).ToString());

            dptosProximos.Add(cand);
          }
        }
      }
      return dptosProximos;
    }

    public IEnumerable<DepartamentoPolicia> CalculaDistancia(string latitudeAtual, string longitudeAtual)
    {
      var deptosProximas = new List<DepartamentoPolicia>();

      var coordAtual = new GeoCoordinate();
      coordAtual.Latitude = double.Parse(latitudeAtual.Replace(",", "."),
            CultureInfo.InvariantCulture);
      coordAtual.Longitude = double.Parse(longitudeAtual.Replace(",", "."),
            CultureInfo.InvariantCulture);

      var dptos = _dptoPoliciaService.GetAll();

      foreach (var dpto in dptos)
      {
        var coordDpto = new GeoCoordinate();

        if (!string.IsNullOrEmpty(dpto.Latitude) || !string.IsNullOrEmpty(dpto.Longitude))
        {
          coordDpto.Latitude = double.Parse(dpto.Latitude.Replace(",", "."),
              CultureInfo.InvariantCulture);
          coordDpto.Longitude = double.Parse(dpto.Longitude.Replace(",", "."),
                CultureInfo.InvariantCulture);

          var distancia = (coordAtual.GetDistanceTo(coordDpto) / 1000);

          if (Math.Round(distancia, 2) <= 10)
          {
            var dptoProximo = new DepartamentoPolicia();
            dptoProximo = dpto;

            dpto.DistanciaColega =
              string.Format("{0} está a {1} km de você", dpto.Nome.Trim(), Math.Round(distancia, 2).ToString());

            deptosProximas.Add(dptoProximo);
          }
        }
      }
      return deptosProximas;
    }
  }
}
