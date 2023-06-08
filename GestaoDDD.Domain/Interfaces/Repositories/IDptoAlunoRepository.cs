﻿using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.TiposPadronizados;
using System.Collections.Generic;

namespace GestaoDDD.Domain.Interfaces.Repositories
{
  public interface IDptoAlunoRepository : IRepositoryBase<DepartamentoAluno>
  {
    IEnumerable<DepartamentoPolicia> PegaDptosPreferenciaAluno(int pAlunoId);
    bool AlunoJaEscolheuUnidade(int pAlunoId, int pDptoPoliciaId);
    DepartamentoAluno PegarDptoPreferenciaPorAluno(int pAlunoId, int pDptoPoliciaId);
    IEnumerable<XGraficoDepartamentosAlunos> PegarGraficoDptosAlunos();
    IEnumerable<XDepartamentoPreferenciaAluno> PegarDptoContempladosAluno(int pAlunoId);
  }
}
