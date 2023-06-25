using GestaoDDD.Application.Interface;
using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GestaoDDD.Application.Services
{
  public class AlunoAppService : AppServiceBase<Aluno>, IAlunoAppService
  {
    private readonly IAlunoService _alunoService;

    public AlunoAppService(IAlunoService alunoService)
        : base(alunoService)
    {
      _alunoService = alunoService;
    }

    public void AtualizarNotaCFP(int pAlunoId, double pNota)
    {
      _alunoService.AtualizarNotaCFP(pAlunoId, pNota);
    }

    public IEnumerable<Aluno> PesquisarAlunosPorPalavras(string pTermo, string pConcorrencia, string pCargo )
    {
     return _alunoService.PesquisarAlunosPorPalavras(pTermo, pConcorrencia, pCargo);
    }
  }
}
