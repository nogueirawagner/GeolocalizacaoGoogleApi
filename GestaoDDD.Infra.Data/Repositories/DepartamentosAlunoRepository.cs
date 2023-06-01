using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Infra.Data.Contexto;
using System.Collections.Generic;
using System.Linq;


namespace GestaoDDD.Infra.Data.Repositories
{
  public class DptoAlunoRepository : RepositoryBase<DepartamentoAluno>, IDptoAlunoRepository
  {
    private readonly GestaoContext _db;
    private readonly IDptoPoliciaRepository _dptoPoliciaRepository;
    public DptoAlunoRepository(GestaoContext dbContext, IDptoPoliciaRepository dptoPoliciaRepository)
        : base(dbContext)
    {
      //nao ppode ser new gestaocontext para nao instanciar novamente o contexto
      _db = dbContext;
      _dptoPoliciaRepository = dptoPoliciaRepository;
    }

    public bool AlunoJaEscolheuUnidade(int pAlunoID, int pDptoPoliciaID)
    {
      return _db.DepartamentoAluno.Any(s => s.AlunoID == pAlunoID && s.DptoID == pDptoPoliciaID);
    }

    public IEnumerable<DepartamentoPolicia> PegaDptosPreferenciaAluno(int pAlunoID)
    {
      return (from da in _db.Set<DepartamentoAluno>()
                   join dp in _db.Set<DepartamentoPolicia>()
                   on da.DptoID equals dp.ID
                    where da.AlunoID == pAlunoID
                   select dp).ToList();
    }

    public DepartamentoAluno PegarDptoPreferenciaPorAluno(int pAlunoId, int pDptoPoliciaId)
    {
      return (from da in _db.Set<DepartamentoAluno>()
             where da.AlunoID == pAlunoId && da.DptoID == pDptoPoliciaId
             select da).FirstOrDefault();
    }
  }
}
