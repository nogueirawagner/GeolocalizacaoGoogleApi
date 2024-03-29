﻿using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Estatics.TypesPatterns;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GestaoDDD.Domain.Services
{
  public class DptoAlunoService : ServiceBase<DepartamentoAluno>, IDptoAlunoService
  {

    private readonly IDptoAlunoRepository _dptoAlunoRepository;

    public DptoAlunoService(IDptoAlunoRepository dptoAlunoRepository)
    : base(dptoAlunoRepository)
    {
      _dptoAlunoRepository = dptoAlunoRepository;
    }

    public bool AlunoJaEscolheuUnidade(int pAlunoID, int pDptoPoliciaID)
    {
      return _dptoAlunoRepository.AlunoJaEscolheuUnidade(pAlunoID, pDptoPoliciaID);
    }

    public IEnumerable<DepartamentoPolicia> PegaDptosPreferenciaAluno(int pAlunoID)
    {
      return _dptoAlunoRepository.PegaDptosPreferenciaAluno(pAlunoID);
    }

    public IEnumerable<XDepartamentoPreferenciaAluno> PegarDptoContempladosAluno(int pAlunoId)
    {
      return _dptoAlunoRepository.PegarDptoContempladosAluno(pAlunoId);
    }

    public DepartamentoAluno PegarDptoPreferenciaPorAluno(int pAlunoId, int pDptoPoliciaId)
    {
      return _dptoAlunoRepository.PegarDptoPreferenciaPorAluno(pAlunoId, pDptoPoliciaId);
    }

    public IEnumerable<XGraficoDepartamentosAlunos> PegarGraficoDptosAlunos()
    {
      return _dptoAlunoRepository.PegarGraficoDptosAlunos();
    }

    public IEnumerable<XPreferenciasRISP> PegarPreferenciaAlunosPorRegioes()
    {
      return _dptoAlunoRepository.PegarPreferenciaAlunosPorRegioes();
    }

    public IEnumerable<XPreferenciasBairro> PegarPreferenciaAlunosPorBairros()
    {
      return _dptoAlunoRepository.PegarPreferenciaAlunosPorBairros();
    }
  }
}
