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
  public class AlunoController : Controller
  {
    private readonly IDptoPoliciaAppService _dptoPoliciaApp;
    private readonly IAlunoAppService _alunoAppService;
    private readonly IDptoAlunoAppService _dptoAlunoService;

    public AlunoController(IDptoPoliciaAppService dptoPoliciaApp,
      IAlunoAppService alunoAppService,
      IDptoAlunoAppService dptoAlunoService
      )
    {
      _dptoPoliciaApp = dptoPoliciaApp;
      _alunoAppService = alunoAppService;
      _dptoAlunoService = dptoAlunoService;
    }

    public ActionResult BuscarAlunos()
    {
      var alunos = _alunoAppService.GetAll().Where(s => s.Concorrencia == "Ampla").OrderByDescending(s => s.NotaEtapa1);
      int i = 1;
      var alunosVm = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(alunos).ToList();
      alunosVm.ForEach(s =>
        {
          s.Posicao = i++;
          s.NotaFinal = s.NotaEtapa1 + s.NotaEtapa2 + s.NotaSAT + s.NotaTIPDPP;
        });
      return View(alunosVm);
    }

    public ActionResult BuscaAlunosFiltro(string pFiltro)
    {
      var alunos = _alunoAppService.GetAll().Where(s => s.Concorrencia == pFiltro).OrderByDescending(s => s.NotaEtapa1);
      int i = 1;
      var alunosVm = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(alunos).ToList();
      alunosVm.ForEach(s =>
      {
        s.Posicao = i++;
        s.NotaFinal = s.NotaEtapa1 + s.NotaEtapa2 + s.NotaSAT + s.NotaTIPDPP;
      });
      return PartialView(alunosVm);
    }


    public ActionResult PainelAluno(int pAlunoId, string pNome, float pNotaFinal)
    {
      ViewBag.Id = pAlunoId;
      ViewBag.Nome = pNome;
      ViewBag.NotaFinal = pNotaFinal;


      var dptos = _dptoPoliciaApp.GetAll()
       .OrderByDescending(s => s.Vagas);
      var dptoVm = Mapper.Map<IEnumerable<DepartamentoPolicia>, IEnumerable<DepartamentoPoliciaViewModel>>(dptos);

      return View(dptoVm);
    }

    public ActionResult BuscaDptosPolicia()
    {
      var dptos = _dptoPoliciaApp.GetAll()
        .OrderByDescending(s => s.Vagas);
      var dptoVm = Mapper.Map<IEnumerable<DepartamentoPolicia>, IEnumerable<DepartamentoPoliciaViewModel>>(dptos);

      return PartialView(dptoVm);
    }

    public ActionResult BuscaDptosPreferenciaAluno()
    {
      var dptos = _dptoPoliciaApp.GetAll()
        .OrderByDescending(s => s.Vagas);
      var dptoVm = Mapper.Map<IEnumerable<DepartamentoPolicia>, IEnumerable<DepartamentoPoliciaViewModel>>(dptos);

      return PartialView(dptoVm);
    }

    public void EscolherLotacao(int pLotacaoID, int pAlunoID)
    {
      var dpto = _dptoPoliciaApp.GetById(pLotacaoID);
      var aluno = _alunoAppService.GetById(pAlunoID);

      if (dpto != null && aluno != null)
      {
        var dptoAluno = new DepartamentoAluno
        {
          AlunoID = pAlunoID,
          DptoID = pLotacaoID
        };
        _dptoAlunoService.Add(dptoAluno);
      }
    }
  }
}
