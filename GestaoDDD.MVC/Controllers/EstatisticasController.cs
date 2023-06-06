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
      var dptoAluno = _dptoAlunoAppService.GetAll();
      var dp = new DelegaciasPessoas();
      var lista = dp.Pegar();
      return Json(lista, JsonRequestBehavior.AllowGet);
    }
  }

  public class DelegaciasPessoas
  {
    public string Nome { get; set; }
    public int Vagas { get; set; }
    public int Pessoas { get; set; }

    public DelegaciasPessoas()
    {

    }

    public DelegaciasPessoas(string pNome, int vagas, int pessoas)
    {
      var rnd = new Random();
      Nome = pNome;
      Vagas = vagas;
      Pessoas = pessoas;
    }

    public List<DelegaciasPessoas> Pegar()
    {
      var list = new List<DelegaciasPessoas>();
      var rnd = new Random();
      
      list.Add(new DelegaciasPessoas("01ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("02ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("03ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("04ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("05ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("06ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("07ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("08ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("09ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("10ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("11ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("12ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("13ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("14ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("15ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("16ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("17ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("18ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("19ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("20ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("21ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("22ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("23ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("24ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("25ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("26ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("27ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("28ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      list.Add(new DelegaciasPessoas("29ª DP", rnd.Next(50, 200), rnd.Next(20, 150)));
      return list;

    }
  }
}