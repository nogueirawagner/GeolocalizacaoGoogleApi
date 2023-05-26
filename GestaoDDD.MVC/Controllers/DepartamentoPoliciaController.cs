using AutoMapper;
using GestaoDDD.Application.Interface;
using GestaoDDD.Application.ViewModels;
using GestaoDDD.Domain.Entities;
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

        var dptos = _dptoPoliciaApp.BuscaDelegaciasProximas(Latitude, Longitude)
          .Where(s => s.ID != Id)
          .OrderByDescending(s => s.Vagas);
          
        var dptoVM = Mapper.Map<IEnumerable<DepartamentoPolicia>, IEnumerable<DepartamentoPoliciaViewModel>>(dptos);
        return View(dptoVM);
      }
      else
      {
        var dptos = _dptoPoliciaApp.GetAll();
        var dptoVM = Mapper.Map<IEnumerable<DepartamentoPolicia>, IEnumerable<DepartamentoPoliciaViewModel>>(dptos);
        return View(dptoVM);
      }
    }

    public ActionResult BuscaDelegacias()
    {
      var dptos = _dptoPoliciaApp.GetAll()
        .OrderByDescending(s => s.Vagas);
      var dptoVm = Mapper.Map<IEnumerable<DepartamentoPolicia>, IEnumerable<DepartamentoPoliciaViewModel>>(dptos);
      return View(dptoVm);
    }

    public JsonResult BuscaDelegaciasJson(string Latitude, string Longitude)
    {
      if (string.IsNullOrEmpty(Latitude) && string.IsNullOrEmpty(Longitude))
      {
        var retorno = _dptoPoliciaApp.GetAll().OrderByDescending(s => s.Vagas);
        return Json(retorno, JsonRequestBehavior.AllowGet);
      }
      else
      {
        var retorno = _dptoPoliciaApp.CalculaDistancia(Latitude, Longitude).OrderByDescending(s => s.Vagas);
        return Json(retorno, JsonRequestBehavior.AllowGet);
      }
    }

    public JsonResult BuscaDelegaciasProximasJson(string Latitude, string Longitude, int Id)
    {
      if (string.IsNullOrEmpty(Latitude) && string.IsNullOrEmpty(Longitude))
      {
        var retorno = _dptoPoliciaApp.GetAll();
        return Json(retorno, JsonRequestBehavior.AllowGet);
      }
      else
      {
        var retorno = _dptoPoliciaApp.BuscaDelegaciasProximas(Latitude, Longitude)
          .Where(s => s.ID != Id);
        return Json(retorno, JsonRequestBehavior.AllowGet);
      }
    }


    //public ActionResult Editar(int Id)
    //{
    //  var dpto = _dptoPoliciaApp.GetById(Id);
    //  var dptoVM = Mapper.Map<DepartamentoPolicia, DepartamentoPoliciaViewModel>(dpto);
    //  return View(dptoVM);
    //}

    //public ActionResult Excluir(int Id)
    //{
    //  var candidato = _candidatoApp.GetById(Id);
    //  _candidatoApp.Remove(candidato);
    //  return RedirectToAction("BuscaCandidatos");
    //}

    //[HttpPost]
    //public ActionResult Editar(CandidatoViewModel candidato)
    //{
    //  try
    //  {
    //    if (ModelState.IsValid)
    //    {
    //      var candidatoViewModel = Mapper.Map<CandidatoViewModel, Candidato>(candidato);
    //      _candidatoApp.Update(candidatoViewModel);
    //    }
    //    else
    //    {
    //      return View(candidato);
    //    }
    //    return RedirectToAction("BuscaCandidatos");
    //  }
    //  catch
    //  {
    //    return View();
    //  }
    //}
  }
}
