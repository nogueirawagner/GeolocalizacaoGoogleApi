using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Estatics.TypesPatterns;
using System.Collections.Generic;

namespace GestaoDDD.Application.Interface
{
  public interface IDptoAlunoAppService : IAppServiceBase<DepartamentoAluno>
  {
    IEnumerable<DepartamentoPolicia> PegaDptosPreferenciaAluno(int pAlunoID);
    bool AlunoJaEscolheuUnidade(int pAlunoID, int pDptoPoliciaID);
    DepartamentoAluno PegarDptoPreferenciaPorAluno(int pAlunoId, int pDptoPoliciaId);
    IEnumerable<XGraficoDepartamentosAlunos> PegarGraficoDptosAlunos();
    IEnumerable<XDepartamentoPreferenciaAluno> PegarDptoContempladosAluno(int pAlunoId);
    IEnumerable<XPreferenciasRISP> PegarPreferenciaAlunosPorRegioes();
  }
}
