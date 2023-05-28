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
  }
}
