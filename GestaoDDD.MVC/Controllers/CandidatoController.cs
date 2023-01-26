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
        return RedirectToAction("CandidatoCadastroSucesso");
      }
      catch
      {
        return View();
      }
    }

    public ActionResult BuscaCandidatos()
    {
      return View();
    }

    public ActionResult CandidatoCadastroSucesso()
    {

      return View();
    }
  }
}
