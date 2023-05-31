using GestaoDDD.Domain.Entities;
using System.Collections.Generic;

namespace GestaoDDD.Domain.Interfaces.Repositories
{
  public interface IDptoAlunoRepository : IRepositoryBase<DepartamentoAluno>
  {
    IEnumerable<DepartamentoPolicia> PegaDptosPreferenciaAluno(int pAlunoID);
    bool AlunoJaEscolheuUnidade(int pAlunoID, int pDptoPoliciaID);
  }
}
