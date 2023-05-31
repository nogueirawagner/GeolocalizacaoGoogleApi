using GestaoDDD.Domain.Entities;
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
  }
}
