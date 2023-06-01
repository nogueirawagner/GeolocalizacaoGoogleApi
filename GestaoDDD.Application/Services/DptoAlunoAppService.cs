using AutoMapper;
using GeoCoordinatePortable;
using GestaoDDD.Application.Interface;
using GestaoDDD.Application.ViewModels;
using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace GestaoDDD.Application.Services
{
  public class DptoAlunoAppService : AppServiceBase<DepartamentoAluno>, IDptoAlunoAppService
  {
    private readonly IDptoAlunoService _dptoAlunoService;

    public DptoAlunoAppService(IDptoAlunoService dptoAlunoService)
        : base(dptoAlunoService)
    {
      _dptoAlunoService = dptoAlunoService;
    }

    public bool AlunoJaEscolheuUnidade(int pAlunoId, int pDptoPoliciaId)
    {
      return _dptoAlunoService.AlunoJaEscolheuUnidade(pAlunoId, pDptoPoliciaId);
    }

    public IEnumerable<DepartamentoPolicia> PegaDptosPreferenciaAluno(int pAlunoId)
    {
      return _dptoAlunoService.PegaDptosPreferenciaAluno(pAlunoId);
    }

    public DepartamentoAluno PegarDptoPreferenciaPorAluno(int pAlunoId, int pDptoPoliciaId)
    {
      return _dptoAlunoService.PegarDptoPreferenciaPorAluno(pAlunoId, pDptoPoliciaId);
    }
  }
}
