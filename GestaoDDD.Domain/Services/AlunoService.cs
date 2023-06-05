using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Domain.Interfaces.Services;

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
  }
}
