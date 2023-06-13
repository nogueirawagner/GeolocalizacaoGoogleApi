using AutoMapper;
using GestaoDDD.Application.Interface;
using GestaoDDD.Application.ViewModels;
using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Estatics;
using GestaoDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoDDD.MVC.Controllers
{
  public class DepartamentoPoliciaController : Controller
  {
    private readonly IDptoPoliciaAppService _dptoPoliciaApp;

    public DepartamentoPoliciaController(IDptoPoliciaAppService dptoPoliciaApp)
    {
      _dptoPoliciaApp = dptoPoliciaApp;
    }


    // GET: Candidato/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: Candidato/Create
    [HttpPost]
    public ActionResult Create(DepartamentoPoliciaViewModel depto)
    {
      try
      {
        if (ModelState.IsValid)
        {
          var dptoViewModel = Mapper.Map<DepartamentoPoliciaViewModel, DepartamentoPolicia>(depto);
          _dptoPoliciaApp.Add(dptoViewModel);
          return View();
        }
        else
        {
          return View(depto);
        }

      }
      catch
      {
        return View();
      }
    }

    public ActionResult BuscaDelegaciasProximas(string Latitude, string Longitude, string Endereco, int Id, string Nome)
    {
      ViewBag.Latitude = null;
      ViewBag.Longitude = null;

      if (!string.IsNullOrEmpty(Latitude) && !string.IsNullOrEmpty(Longitude))
      {
        ViewBag.Latitude = Latitude;
        ViewBag.Longitude = Longitude;
        ViewBag.Endereco = Endereco;
        ViewBag.Id = Id;
        ViewBag.Nome = Nome;

        var key = string.Concat("BuscaDelegaciasProximas-", Id, Latitude, Longitude);
        if (XAppCache.Has(key))
          return XAppCache.Get<ActionResult>(key);
        else
        {
          var dptos = _dptoPoliciaApp.BuscaDelegaciasProximas(Latitude, Longitude)
            .Where(s => s.ID != Id)
            .OrderByDescending(s => s.Vagas);

          var dptoVM = Mapper.Map<IEnumerable<DepartamentoPolicia>, IEnumerable<DepartamentoPoliciaViewModel>>(dptos);
          return XAppCache.Set(key, View(dptoVM));
        }
      }
      else
      {
        return BuscaDelegacias();
      }
    }

    public ActionResult BuscaDelegacias()
    {
      var key = "BuscaDelegacias";
      if (XAppCache.Has(key))
        return XAppCache.Get<ActionResult>(key);
      else
      {
        var dptos = _dptoPoliciaApp.GetAll()
          .OrderByDescending(s => s.Vagas);
        var dptoVm = Mapper.Map<IEnumerable<DepartamentoPolicia>, IEnumerable<DepartamentoPoliciaViewModel>>(dptos);

        return XAppCache.Set(key, View(dptoVm));
      }
    }

    public JsonResult BuscaDelegaciasJson(string Latitude, string Longitude)
    {
      if (string.IsNullOrEmpty(Latitude) && string.IsNullOrEmpty(Longitude))
      {
        var key = "BuscaDelegaciasJson";
        if (XAppCache.Has(key))
          return XAppCache.Get<JsonResult>(key);
        else
        {
          var retorno = _dptoPoliciaApp.GetAll().OrderByDescending(s => s.Vagas);
          var json = Json(retorno, JsonRequestBehavior.AllowGet);

          return XAppCache.Set(key, json);
        }
      }
      else
      {
        var key = string.Concat("BuscaDelegaciasJson", Latitude, Longitude);

        if (XAppCache.Has(key))
          return XAppCache.Get<JsonResult>(key);
        else
        {
          var retorno = _dptoPoliciaApp.CalculaDistancia(Latitude, Longitude).OrderByDescending(s => s.Vagas);
          var json = Json(retorno, JsonRequestBehavior.AllowGet);

          return XAppCache.Set(key, json);
        }
      }
    }

    public JsonResult BuscaDelegaciasProximasJson(string Latitude, string Longitude, int Id)
    {
      if (string.IsNullOrEmpty(Latitude) && string.IsNullOrEmpty(Longitude))
      {
        var key = "BuscaDelegaciasJson";
        if (XAppCache.Has(key))
          return XAppCache.Get<JsonResult>(key);
        else
        {
          var retorno = _dptoPoliciaApp.GetAll().OrderByDescending(s => s.Vagas);
          var json = Json(retorno, JsonRequestBehavior.AllowGet);

          return XAppCache.Set(key, json);
        }
      }
      else
      {
        var key = string.Concat("BuscaDelegaciasProximasJson-", Id, Latitude, Longitude);
        if (XAppCache.Has(key))
          return XAppCache.Get<JsonResult>(key);
        else
        {
          var dptos = _dptoPoliciaApp.BuscaDelegaciasProximas(Latitude, Longitude)
            .Where(s => s.ID != Id)
            .OrderByDescending(s => s.Vagas);

          var json = Json(dptos, JsonRequestBehavior.AllowGet);
          return XAppCache.Set(key, json);
        }
      }
    }
  }
}
