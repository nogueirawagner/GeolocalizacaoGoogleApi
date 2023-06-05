using GestaoDDD.Domain.Entities;

namespace GestaoDDD.Domain.Interfaces.Services
{
  public interface IAlunoService : IServiceBase<Aluno>
  {
    void AtualizarNotaCFP(int pAlunoId, double pNota);
  }
}
