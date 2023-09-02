using AutoMapper;
using GestaoDDD.Application.Interface;
using GestaoDDD.Application.ViewModels;
using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Estatics;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GestaoDDD.MVC.Controllers
{
  public class AlunoController : Controller
  {
    private readonly IDptoPoliciaAppService _dptoPoliciaAppService;
    private readonly IAlunoAppService _alunoAppService;
    private readonly IDptoAlunoAppService _dptoAlunoAppService;

    public AlunoController(IDptoPoliciaAppService dptoPoliciaAppService,
      IAlunoAppService alunoAppService,
      IDptoAlunoAppService dptoAlunoAppService
      )
    {
      _dptoPoliciaAppService = dptoPoliciaAppService;
      _alunoAppService = alunoAppService;
      _dptoAlunoAppService = dptoAlunoAppService;
    }

    private IEnumerable<AlunoViewModel> VerificarTurmasNomeacao(string pConcorrencia)
    {
      var lista_ampla = new List<AlunoViewModel>();
      var lista_negros = new List<AlunoViewModel>();
      var lista_pcd = new List<AlunoViewModel>();

      var ampla = _alunoAppService.PegarAlunosPorCargoConcorrencia("Agente", "Ampla");
      var amplaVm = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(ampla).ToList();


      lista_ampla.AddRange(amplaVm.Take(5));
      foreach (var amp in lista_ampla)
        amp.Turma = "T1";

      var negros = _alunoAppService.PegarAlunosPorCargoConcorrencia("Agente", "Negros");
      var negrosVm = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(negros).ToList();

      lista_negros.AddRange(negrosVm.Take(2));
      foreach (var ng in lista_negros)
        ng.Turma = "T1";

      var pcd = _alunoAppService.PegarAlunosPorCargoConcorrencia("Agente", "PCD");
      var pcdVm = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(pcd).ToList();

      lista_pcd.AddRange(pcdVm.Take(1));
      foreach (var pc in pcdVm)
        pc.Turma = "T1";

      var resto_ampla = amplaVm.Skip(5).ToList();
      var resto_negros = negrosVm.Skip(2).ToList();
      var resto_pcd = pcdVm.Skip(1).ToList();

      var parada = resto_ampla.Count();

      int posicao_ampla = 6, posicao_negro = 3, posicao_pcd = 1;
      int ultima_posicao_negro = 3, ultima_posicao_pcd = 2;

      for (int i = 6; i < parada; i++)
      {

        var obj = resto_ampla[0];
        obj.Turma = posicao_ampla <= 450 ? "T1"
                     : posicao_ampla > 450 && posicao_ampla < 900 ? "T2"
                     : "T3";

        posicao_ampla += 1;

        lista_ampla.Add(obj);
        resto_ampla.Remove(obj);

        // negros fixos na posição 3 e 8;.

        if (obj.PosicaoProvisoria == posicao_negro + 5)
        {
          if (resto_negros.Count() > 0)
          {
            var obj_negro = resto_negros[0];
            obj_negro.Turma = ultima_posicao_negro <= 120 ? "T1"
                : ultima_posicao_negro > 120 && ultima_posicao_negro < 240 ? "T2"
                : "T3";


            posicao_negro += 5;
            ultima_posicao_negro += 1;

            lista_negros.Add(obj_negro);
            resto_negros.Remove(obj_negro);
          }
        }

        if (obj.PosicaoProvisoria == posicao_pcd + 20)
        {
          if (resto_pcd.Count() > 0)
          {
            var obj_pcd = resto_pcd[0];
            obj_pcd.Turma = ultima_posicao_pcd <= 30 ? "T1"
                       : ultima_posicao_pcd > 30 && ultima_posicao_pcd < 60 ? "T2"
                       : "T3";

            posicao_pcd += 20;
            ultima_posicao_pcd += 1;

            lista_pcd.Add(obj_pcd);
            resto_pcd.Remove(obj_pcd);
          }
        }
      }

      var faltaPcd = 30 - lista_pcd.Count();
      var posicaoUltimoT1 = lista_ampla.Last(s => s.Turma == "T1");
      var indexUltimoT1 = lista_ampla.IndexOf(posicaoUltimoT1);

      var amplaPcd = lista_ampla.Skip(indexUltimoT1 + 1).Take(faltaPcd);
      foreach (var ampPcd in amplaPcd)
        ampPcd.Turma = "T1";

      var keyAmpla = "TurmasAmpla";
      var keyNegros = "TurmasNegros";
      var keyPCD = "TurmasPCD";

      if (pConcorrencia == "Ampla")
      {
        if (XAppCache.Has(keyAmpla))
        {
          XAppCache.Alter<List<AlunoViewModel>>(keyAmpla, lista_ampla);
          return XAppCache.Get<List<AlunoViewModel>>(keyAmpla);
        }
        else
        {
          return XAppCache.Set(keyAmpla, lista_ampla);
        }
      }
      else if (pConcorrencia == "Negros")
      {
        if (XAppCache.Has(keyNegros))
        {
          XAppCache.Alter<List<AlunoViewModel>>(keyNegros, lista_negros);
          return XAppCache.Get<List<AlunoViewModel>>(keyNegros);
        }
        else
        {
          return XAppCache.Set(keyNegros, lista_negros);
        }
      }
      else
      {
        if (XAppCache.Has(keyPCD))
        {
          XAppCache.Alter<List<AlunoViewModel>>(keyPCD, lista_pcd);
          return XAppCache.Get<List<AlunoViewModel>>(keyPCD);
        }
        else
        {
          return XAppCache.Set(keyPCD, lista_pcd);
        }
      }
    }

    public ActionResult BuscarAlunos()
    {


      var alunos = _alunoAppService.PegarAlunosPorCargoConcorrencia("Agente", "Ampla");
      //var alunosVm = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(alunos).ToList();

      var alunosVm = VerificarTurmasNomeacao("Ampla");

      ViewBag.Media = _alunoAppService.PegarMediaCalculada();

      return View(alunosVm);
      /*
      var key = string.Concat("AlunosConcorrencia-", "Agente", "Ampla");
      if (XAppCache.Has(key))
        return XAppCache.Get<ActionResult>(key);
      else
      {
        var alunos = _alunoAppService.PegarAlunosPorCargoConcorrencia("Agente", "Ampla");
        var alunosVm = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(alunos).ToList();
        
        return XAppCache.Set(key, View(alunosVm));
      }
      */
    }

    public ActionResult BuscaAlunosFiltro(string pCargo, string pConcorrencia)
    {
      var alunos = _alunoAppService.PegarAlunosPorCargoConcorrencia(pCargo, pConcorrencia);

      if (pConcorrencia == "Ampla" || pConcorrencia == "Negros" || pConcorrencia == "PCD")
      {
        var alunosVm = VerificarTurmasNomeacao(pConcorrencia);
        ViewBag.Media = _alunoAppService.PegarMediaCalculada();

        return PartialView(alunosVm);
      }
      else
      {
        var alunosVm = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(alunos).ToList();
        ViewBag.Media = _alunoAppService.PegarMediaCalculada();

        return PartialView(alunosVm);
      }


      /*
      var key = string.Concat("AlunosConcorrencia-Partial-", pCargo, pConcorrencia);

      if (XAppCache.Has(key))
      {
        return XAppCache.Get<ActionResult>(key);
      }
      else
      {
        var alunos = _alunoAppService.PegarAlunosPorCargoConcorrencia(pCargo, pConcorrencia);
        var alunosVm = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(alunos).ToList();
        return XAppCache.Set(key, PartialView(alunosVm));
      }

      */
    }

    public JsonResult PesquisarAlunosPorPalavras(string pTermo, string pConcorrencia, string pCargo)
    {
      var alunos = _alunoAppService.PesquisarAlunosPorPalavras(pTermo, pConcorrencia, pCargo);
      var alunosVm = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(alunos).ToList();

      if (alunosVm.Count == 0)
        return null;

      if (pConcorrencia == "Ampla")
      {
        var turmasAmpla = XAppCache.Get<List<AlunoViewModel>>("TurmasAmpla");
        foreach (var aVm in alunosVm)
        {
          aVm.Turma = turmasAmpla.FirstOrDefault(s => s.ID == aVm.ID).Turma;
        }
        return Json(alunosVm, JsonRequestBehavior.AllowGet);
      }
      else if (pConcorrencia == "Negros")
      {
        var turmasNegro = XAppCache.Get<List<AlunoViewModel>>("TurmasNegros");
        foreach (var aVm in alunosVm)
        {
          aVm.Turma = turmasNegro.FirstOrDefault(s => s.ID == aVm.ID).Turma;
        }
        return Json(alunosVm, JsonRequestBehavior.AllowGet);
      }
      else if (pConcorrencia == "PCD")
      {
        var turmasPCD = XAppCache.Get<List<AlunoViewModel>>("TurmasPCD");
        foreach (var aVm in alunosVm)
        {
          aVm.Turma = turmasPCD.FirstOrDefault(s => s.ID == aVm.ID).Turma;
        }
        return Json(alunosVm, JsonRequestBehavior.AllowGet);
      }
      else
        return Json(alunosVm, JsonRequestBehavior.AllowGet);
    }

    public ActionResult PainelAluno(int pAlunoId)
    {
      var aluno = _alunoAppService.GetById(pAlunoId);
      ViewBag.Id = pAlunoId;
      ViewBag.Nome = aluno.Nome;
      ViewBag.NotaFinal = aluno.NotaEtapa1 + aluno.NotaEtapa2;
      ViewBag.NotaEtapa1 = aluno.NotaEtapa1;
      ViewBag.NotaEtapa2 = aluno.NotaEtapa2;
      ViewBag.Inscricao = aluno.Inscricao;
      ViewBag.Cargo = aluno.Cargo;
      ViewBag.Posicao = aluno.Posicao;
      ViewBag.PosicaoProvisoria = aluno.PosicaoProvisoria;

      var dptos = _dptoPoliciaAppService.GetAll()
         .OrderByDescending(s => s.Pontuacao);
      var dptoVm = Mapper.Map<IEnumerable<DepartamentoPolicia>, IEnumerable<DepartamentoPoliciaViewModel>>(dptos);

      return View(dptoVm);

      //var key = "BuscaDelegacias";
      //if (XAppCache.Has(key))
      //  return XAppCache.Get<ActionResult>(key);
      //else
      //{
      //  var dptos = _dptoPoliciaAppService.GetAll()
      //    .OrderByDescending(s => s.Pontuacao);
      //  var dptoVm = Mapper.Map<IEnumerable<DepartamentoPolicia>, IEnumerable<DepartamentoPoliciaViewModel>>(dptos);

      //  return XAppCache.Set(key, View(dptoVm));
      //}
    }

    //public ActionResult BuscaDptosPolicia()
    //{
    //  var dptos = _dptoPoliciaAppService.GetAll()
    //    .OrderByDescending(s => s.Vagas);
    //  var dptoVm = Mapper.Map<IEnumerable<DepartamentoPolicia>, IEnumerable<DepartamentoPoliciaViewModel>>(dptos);

    //  return PartialView(dptoVm);
    //}

    public void AtualizarNotaCFP(int pAlunoId, double pNota)
    {
      _alunoAppService.AtualizarNotaCFP(pAlunoId, pNota);
    }

    public JsonResult BuscaDptosPreferenciaAluno(int pAlunoID)
    {
      var dptoContemplados = _dptoAlunoAppService.PegarDptoContempladosAluno(pAlunoID);
      return Json(dptoContemplados, JsonRequestBehavior.AllowGet);
    }

    public void ExcluirDptoPreferencia(int pAlunoId, int pDptoId)
    {
      var dptoAluno = _dptoAlunoAppService.PegarDptoPreferenciaPorAluno(pAlunoId, pDptoId);
      _dptoAlunoAppService.Remove(dptoAluno);
    }

    public void EscolherLotacao(int pLotacaoID, int pAlunoID)
    {
      var jaEscolheu = _dptoAlunoAppService.AlunoJaEscolheuUnidade(pAlunoID, pLotacaoID);

      if (!jaEscolheu)
      {
        var dptoAluno = new DepartamentoAluno
        {
          AlunoID = pAlunoID,
          DptoID = pLotacaoID
        };
        _dptoAlunoAppService.Add(dptoAluno);
      }
    }
  }
}
