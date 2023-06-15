using GestaoDDD.Application.Interface;
using GestaoDDD.Domain.Estatics;
using System.Web.Mvc;

namespace GestaoDDD.MVC.Controllers
{
  public class EstatisticasController : Controller
  {
    private readonly IDptoAlunoAppService _dptoAlunoAppService;

    public EstatisticasController(IDptoAlunoAppService dptoAlunoAppService)
    {
      _dptoAlunoAppService = dptoAlunoAppService;
    }

    public ActionResult EstatisticasDF()
    {
      return View();
    }

    public JsonResult PegarDelegaciasPessoas()
    {
      var key = "PegarDelegaciasPessoas";
      if (XAppCache.Has(key))
        return XAppCache.Get<JsonResult>(key);
      else
      {
        var grafico = _dptoAlunoAppService.PegarGraficoDptosAlunos();
        var json = Json(grafico, JsonRequestBehavior.AllowGet);

        return XAppCache.Set(key, json);
      }
    }

    public JsonResult PegarPreferenciaAlunosPorRegioes()
    {
      var grafico = _dptoAlunoAppService.PegarPreferenciaAlunosPorRegioes();
      var json = Json(grafico, JsonRequestBehavior.AllowGet);
      return json;
    }

    public JsonResult PegarPreferenciaAlunosPorBairros()
    {
      var grafico = _dptoAlunoAppService.PegarPreferenciaAlunosPorBairros();
      var json = Json(grafico, JsonRequestBehavior.AllowGet);
      return json;
    }
  }
}