using GestaoDDD.Application.Interface;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace GestaoDDD.MVC.Controllers
{
  public class EstatisticasController : Controller
  {
    private readonly IDptoPoliciaAppService _dptoPoliciaAppService;
    private readonly IAlunoAppService _alunoAppService;
    private readonly IDptoAlunoAppService _dptoAlunoAppService;

    public EstatisticasController(IDptoPoliciaAppService dptoPoliciaAppService,
      IAlunoAppService alunoAppService,
      IDptoAlunoAppService dptoAlunoAppService
      )
    {
      _dptoPoliciaAppService = dptoPoliciaAppService;
      _alunoAppService = alunoAppService;
      _dptoAlunoAppService = dptoAlunoAppService;
    }

    public ActionResult Estatisticas()
    {
      return View();
    }

    public ActionResult EstatisticasDF()
    {
      return PartialView();
    }

    public JsonResult PegarDelegaciasPessoas()
    {
      var grafico = _dptoAlunoAppService.PegarGraficoDptosAlunos();
      return Json(grafico, JsonRequestBehavior.AllowGet);
    }
  }
}