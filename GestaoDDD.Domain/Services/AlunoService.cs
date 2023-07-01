using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GestaoDDD.Domain.Services
{
  public class AlunoService : ServiceBase<Aluno>, IAlunoService
  {
    private readonly IAlunoRepository _alunoRepository;

    public AlunoService(IAlunoRepository alunoRepository)
    : base(alunoRepository)
    {
      _alunoRepository = alunoRepository;
    }

    public void AtualizarNotaCFP(int pAlunoId, double pNota)
    {
      _alunoRepository.AtualizarNotaCFP(pAlunoId, pNota);
    }

    public IEnumerable<Aluno> PegarAlunosPorCargoConcorrencia(string pCargo, string pConcorrencia)
    {
      return _alunoRepository.PegarAlunosPorCargoConcorrencia(pCargo, pConcorrencia);
    }

    public IEnumerable<Aluno> PesquisarAlunosPorPalavras(string pTermo, string pConcorrencia, string pCargo)
    {
      return _alunoRepository.PesquisarAlunosPorPalavras(pTermo, pConcorrencia, pCargo);
    }
  }
}
