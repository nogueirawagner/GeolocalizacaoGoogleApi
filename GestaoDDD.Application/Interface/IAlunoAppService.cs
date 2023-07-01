using GestaoDDD.Domain.Entities;
using System.Collections.Generic;

namespace GestaoDDD.Application.Interface
{
  public interface IAlunoAppService : IAppServiceBase<Aluno>
  {
    void AtualizarNotaCFP(int pAlunoId, double pNota);
    IEnumerable<Aluno> PesquisarAlunosPorPalavras(string pTermo, string pConcorrencia, string pCargo);
    IEnumerable<Aluno> PegarAlunosPorCargoConcorrencia(string pCargo, string pConcorrencia);
  }
}
