using GestaoDDD.Application.Interface;
using GestaoDDD.Application.Services;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Domain.Interfaces.Services;
using GestaoDDD.Domain.Services;
using GestaoDDD.Infra.Data.Repositories;
using SimpleInjector;


namespace GestaoDDD.Infra.IoC
{
  public class BootStrapper
  {
    public static void RegisterServices(Container container)
    {
      container.Register<ICandidatoRepository, CandidatoRepository>(Lifestyle.Scoped);
      container.Register<ICandidatoAppService, CandidatoAppService>(Lifestyle.Scoped);
      container.Register<ICandidatoService, CandidatoService>(Lifestyle.Scoped);

      container.Register<IDptoPoliciaRepository, DptoPoliciaRepository>(Lifestyle.Scoped);
      container.Register<IDptoPoliciaAppService, DptoPoliciaAppService>(Lifestyle.Scoped);
      container.Register<IDptoPoliciaService, DptoPoliciaService>(Lifestyle.Scoped);

      container.Register<IAlunoRepository, AlunoRepository>(Lifestyle.Scoped);
      container.Register<IAlunoAppService, AlunoAppService>(Lifestyle.Scoped);
      container.Register<IAlunoService, AlunoService>(Lifestyle.Scoped);

      container.Register<IDptoAlunoRepository, DptoAlunoRepository>(Lifestyle.Scoped);
      container.Register<IDptoAlunoAppService, DptoAlunoAppService>(Lifestyle.Scoped);
      container.Register<IDptoAlunoService, DptoAlunoService>(Lifestyle.Scoped);
    }
  }
}
