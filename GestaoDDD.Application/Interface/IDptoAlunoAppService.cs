using GestaoDDD.Domain.Entities;
using System.Collections.Generic;

namespace GestaoDDD.Application.Interface
{
  public interface IDptoAlunoAppService : IAppServiceBase<DepartamentoAluno>
  {
    IEnumerable<DepartamentoPolicia> PegaDptosPreferenciaAluno(int pAlunoID);
    bool AlunoJaEscolheuUnidade(int pAlunoID, int pDptoPoliciaID);
  }
}
