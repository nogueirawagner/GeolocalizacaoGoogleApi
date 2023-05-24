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

    //public IEnumerable<Candidato> BuscaCandidatosProximos(string latitudeAtual, string longitudeAtual)
    //{
    //  var candidatosProximos = new List<Candidato>();

    //  var coordAtual = new GeoCoordinate();
    //  coordAtual.Latitude = double.Parse(latitudeAtual.Replace(",", "."),
    //        CultureInfo.InvariantCulture);
    //  coordAtual.Longitude = double.Parse(longitudeAtual.Replace(",", "."),
    //        CultureInfo.InvariantCulture);

    //  var candidatos = _candidatoService.GetAll();

    //  foreach (var cand in candidatos)
    //  {
    //    var coordCandidato = new GeoCoordinate();

    //    if (!string.IsNullOrEmpty(cand.Latitude) || !string.IsNullOrEmpty(cand.Longitude))
    //    {
    //      coordCandidato.Latitude = double.Parse(cand.Latitude.Replace(",", "."),
    //          CultureInfo.InvariantCulture);
    //      coordCandidato.Longitude = double.Parse(cand.Longitude.Replace(",", "."),
    //            CultureInfo.InvariantCulture);

    //      var distancia = (coordAtual.GetDistanceTo(coordCandidato) / 1000);

    //      if (Math.Round(distancia, 2) <= 3)
    //      {
    //        var candidato = new Candidato();
    //        candidato = cand;
    //        candidato.DistanciaColega =
    //          string.Format("{0} está a {1} km de você", cand.Nome.Trim(), Math.Round(distancia, 2).ToString());

    //        candidatosProximos.Add(candidato);
    //      }
    //    }
    //  }
    //  return candidatosProximos;
    //}

    //public IEnumerable<Candidato> CalculaDistancia(string latitudeAtual, string longitudeAtual)
    //{
    //  var coordAtual = new GeoCoordinate();
    //  coordAtual.Latitude = double.Parse(latitudeAtual.Replace(",", "."),
    //        CultureInfo.InvariantCulture);
    //  coordAtual.Longitude = double.Parse(longitudeAtual.Replace(",", "."),
    //        CultureInfo.InvariantCulture);

    //  var coordCEPOM = new GeoCoordinate();
    //  coordCEPOM.Latitude = -15.7994772;
    //  coordCEPOM.Longitude = -48.0607247;

    //  var coordESPC = new GeoCoordinate();
    //  coordESPC.Latitude = -15.8851054;
    //  coordESPC.Longitude = -48.0626557;

    //  var distanciaCepom = (coordAtual.GetDistanceTo(coordCEPOM) / 1000);
    //  var distanciaEspc = (coordAtual.GetDistanceTo(coordESPC) / 1000);

    //  var candidatos = _candidatoService.GetAll();

    //  foreach (var cand in candidatos)
    //  {
    //    var coordCandidato = new GeoCoordinate();

    //    if (!string.IsNullOrEmpty(cand.Latitude) || !string.IsNullOrEmpty(cand.Longitude))
    //    {
    //      coordCandidato.Latitude = double.Parse(cand.Latitude.Replace(",", "."),
    //          CultureInfo.InvariantCulture);
    //      coordCandidato.Longitude = double.Parse(cand.Longitude.Replace(",", "."),
    //            CultureInfo.InvariantCulture);

    //      var distancia = (coordAtual.GetDistanceTo(coordCandidato) / 1000);
    //      cand.DistanciaColega =
    //       string.Format("{0} está a {1} km de você", cand.Nome.Trim(), Math.Round(distancia, 2).ToString());

    //      cand.DistanciaEscolas = string.Format("Estou aqui a {0} km do CEPOM e a {1} km da ESPC", Math.Round(distanciaCepom, 2), Math.Round(distanciaEspc, 2));
    //    }
    //  }
    //  return candidatos;
    //}
  }
}
