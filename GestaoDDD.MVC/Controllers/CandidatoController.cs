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

    public ActionResult BuscaCandidatos()
    {
      var candidatos = _candidatoApp.GetAll();
      var candVM = Mapper.Map<IEnumerable<Candidato>, IEnumerable<CandidatoViewModel>>(candidatos);
      return View(candVM);
    }

    public JsonResult BuscaCandidatosJson()
    {
      var retorno = _candidatoApp.GetAll();
      return Json(retorno, JsonRequestBehavior.AllowGet);
    }

    public ActionResult Editar(int Id)
    {
      var candidato = _candidatoApp.GetById(Id);
      var candidatoViewModel = Mapper.Map<Candidato, CandidatoViewModel>(candidato);
      return View(candidatoViewModel);
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
