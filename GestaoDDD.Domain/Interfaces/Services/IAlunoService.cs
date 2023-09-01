using GestaoDDD.Domain.Entities;
using System.Collections.Generic;

namespace GestaoDDD.Domain.Interfaces.Services
{
  public interface IAlunoService : IServiceBase<Aluno>
  {
    void AtualizarNotaCFP(int pAlunoId, double pNota);

    IEnumerable<Aluno> PesquisarAlunosPorPalavras(string pTermo, string pConcorrencia, string pCargo);
    IEnumerable<Aluno> PegarAlunosPorCargoConcorrencia(string pCargo, string pConcorrencia);
    string PegarMediaCalculada();
  }
}
