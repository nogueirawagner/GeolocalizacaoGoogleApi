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

    public ActionResult BuscarAlunos()
    {
      var key = string.Concat("AlunosConcorrencia-", "Agente", "Ampla");

      if (XAppCache.Has(key))
        return XAppCache.Get<ActionResult>(key);
      else
      {
        var alunos = _alunoAppService.PegarAlunosPorCargoConcorrencia("Agente", "Ampla");
        var alunosVm = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(alunos).ToList();
        
        return XAppCache.Set(key, View(alunosVm));
      }
    }

    public ActionResult BuscaAlunosFiltro(string pCargo, string pConcorrencia)
    {
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
    }

    public JsonResult PesquisarAlunosPorPalavras(string pTermo, string pConcorrencia, string pCargo)
    {
      var alunos = _alunoAppService.PesquisarAlunosPorPalavras(pTermo, pConcorrencia, pCargo);

      return Json(alunos, JsonRequestBehavior.AllowGet);
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
