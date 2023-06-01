using GestaoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDDD.Domain.Interfaces.Services
{
  public interface IDptoAlunoService : IServiceBase<DepartamentoAluno>
  {
    IEnumerable<DepartamentoPolicia> PegaDptosPreferenciaAluno(int pAlunoId);
    bool AlunoJaEscolheuUnidade(int pAlunoId, int pDptoPoliciaId);
    DepartamentoAluno PegarDptoPreferenciaPorAluno(int pAlunoId, int pDptoPoliciaId);
  }
}
