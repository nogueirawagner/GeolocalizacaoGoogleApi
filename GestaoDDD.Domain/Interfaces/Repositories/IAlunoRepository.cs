using GestaoDDD.Domain.Entities;

namespace GestaoDDD.Domain.Interfaces.Repositories
{
  public interface IAlunoRepository : IRepositoryBase<Aluno>
  {
    void AtualizarNotaCFP(int pAlunoId, double pNota);
  }
}
