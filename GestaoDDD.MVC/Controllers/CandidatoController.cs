using AutoMapper;
using GestaoDDD.Application.Interface;
using GestaoDDD.Application.ViewModels;
using GestaoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoDDD.MVC.Controllers
{
  public class CandidatoController : Controller
  {
    private readonly ICandidatoAppService _candidatoApp;

    public CandidatoController(ICandidatoAppService candidatoApp)
    {
      _candidatoApp = candidatoApp;
    }


    // GET: Candidato/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: Candidato/Create
    [HttpPost]
    public ActionResult Create(CandidatoViewModel candidato)
    {
      try
      {
        if (ModelState.IsValid)
        {
          var candidatoViewModel = Mapper.Map<CandidatoViewModel, Candidato>(candidato);
          _candidatoApp.Add(candidatoViewModel);

          ViewBag.Latitude = candidatoViewModel.Latitude;
          ViewBag.Longitude = candidatoViewModel.Longitude;

          ViewBag.TodosESPC = candidatoViewModel.Turma == "Todos T1";
          ViewBag.TodosCEPOM = candidatoViewModel.Turma == "Todos T2" || candidatoViewModel.Turma == "Todos T3";

          return RedirectToAction("BuscaCandidatos", new { Latitude = ViewBag.Latitude, Longitude = ViewBag.Longitude, T1 = ViewBag.TodosESPC, T2 = ViewBag.TodosCEPOM });
        }
        else
        {
          return View(candidato);
        }

      }
      catch
      {
        return View();
      }
    }

    public ActionResult BuscaCandidatosProximos(string Latitude, string Longitude, string Endereco, int Id)
    {
      ViewBag.Latitude = null;
      ViewBag.Longitude = null;

      if (!string.IsNullOrEmpty(Latitude) && !string.IsNullOrEmpty(Longitude))
      {
        ViewBag.Latitude = Latitude;
        ViewBag.Longitude = Longitude;
        ViewBag.Endereco = Endereco;
        ViewBag.Id = Id;

        var candidatos = _candidatoApp.BuscaCandidatosProximos(Latitude, Longitude)
          .Where(s => s.ID != Id)
          .OrderByDescending(s => s.QtdVagasCarro)
          .ThenByDescending(s => s.QtdVagasDisponivelCasa);
        var candVM = Mapper.Map<IEnumerable<Candidato>, IEnumerable<CandidatoViewModel>>(candidatos);
        return View(candVM);
      }
      else
      {
        var candidatos = _candidatoApp.GetAll();
        var candVM = Mapper.Map<IEnumerable<Candidato>, IEnumerable<CandidatoViewModel>>(candidatos);
        return View(candVM);
      }
    }

    public ActionResult BuscaCandidatos(string Latitude, string Longitude, string T1, string T2)
    {
      ViewBag.Latitude = null;
      ViewBag.Longitude = null;
      ViewBag.TodosESPC = false;
      ViewBag.TodosCEPOM = false;

      if (!string.IsNullOrEmpty(Latitude) && !string.IsNullOrEmpty(Longitude))
      {
        ViewBag.Latitude = Latitude;
        ViewBag.Longitude = Longitude;
        ViewBag.TodosESPC = bool.Parse(T1.ToLower());
        ViewBag.TodosCEPOM = bool.Parse(T2.ToLower());
      }

      var candidatos = _candidatoApp.GetAll().OrderByDescending(s => s.QtdVagasDisponivelCasa);
      var candVM = Mapper.Map<IEnumerable<Candidato>, IEnumerable<CandidatoViewModel>>(candidatos);
      return View(candVM);
    }

    public JsonResult BuscaCandidatosJson(string Latitude, string Longitude)
    {
      if (string.IsNullOrEmpty(Latitude) && string.IsNullOrEmpty(Longitude))
      {
        var retorno = _candidatoApp.GetAll().OrderByDescending(s => s.QtdVagasDisponivelCasa);
        return Json(retorno, JsonRequestBehavior.AllowGet);
      }
      else
      {
        var retorno = _candidatoApp.CalculaDistancia(Latitude, Longitude).OrderByDescending(s => s.QtdVagasDisponivelCasa);
        return Json(retorno, JsonRequestBehavior.AllowGet);
      }
    }

    public JsonResult BuscaCandidatosProximosJson(string Latitude, string Longitude, int Id)
    {
      if (string.IsNullOrEmpty(Latitude) && string.IsNullOrEmpty(Longitude))
      {
        var retorno = _candidatoApp.GetAll();
        return Json(retorno, JsonRequestBehavior.AllowGet);
      }
      else
      {
        var retorno = _candidatoApp.BuscaCandidatosProximos(Latitude, Longitude)
          .Where(s => s.ID != Id);
        return Json(retorno, JsonRequestBehavior.AllowGet);
      }
    }


    public ActionResult Editar(int Id)
    {
      var candidato = _candidatoApp.GetById(Id);
      var candidatoViewModel = Mapper.Map<Candidato, CandidatoViewModel>(candidato);
      return View(candidatoViewModel);
    }

    public ActionResult Excluir(int Id)
    {
      var candidato = _candidatoApp.GetById(Id);
      _candidatoApp.Remove(candidato);
      return RedirectToAction("BuscaCandidatos");
    }

    [HttpPost]
    public ActionResult Editar(CandidatoViewModel candidato)
    {
      try
      {
        if (ModelState.IsValid)
        {
          var candidatoViewModel = Mapper.Map<CandidatoViewModel, Candidato>(candidato);
          _candidatoApp.Update(candidatoViewModel);
        }
        else
        {
          return View(candidato);
        }
        return RedirectToAction("BuscaCandidatos");
      }
      catch
      {
        return View();
      }
    }
  }
}
