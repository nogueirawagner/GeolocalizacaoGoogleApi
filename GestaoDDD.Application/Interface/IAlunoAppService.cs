using GestaoDDD.Domain.Entities;

namespace GestaoDDD.Application.Interface
{
  public interface IAlunoAppService : IAppServiceBase<Aluno>
  {
    void AtualizarNotaCFP(int pAlunoId, double pNota);
  }
}
