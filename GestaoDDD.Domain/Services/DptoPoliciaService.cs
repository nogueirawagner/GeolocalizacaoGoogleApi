using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GestaoDDD.Domain.Services
{
  public class DptoPoliciaService : ServiceBase<DepartamentoPolicia>, IDptoPoliciaService
  {

    private readonly IDptoPoliciaRepository _dptoPoliciaRepository;

    public DptoPoliciaService(IDptoPoliciaRepository dptoPoliciaRepository)
    : base(dptoPoliciaRepository)
    {
      _dptoPoliciaRepository = dptoPoliciaRepository;
    }
  }
}
