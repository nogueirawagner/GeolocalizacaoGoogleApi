using GestaoDDD.Application.Interface;
using GestaoDDD.Application.Services;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Domain.Interfaces.Services;
using GestaoDDD.Domain.Services;
using GestaoDDD.Infra.Data.Contexto;
using GestaoDDD.Infra.Data.Repositories;
using GestaoDDD.Infra.Identity.Configuration;
using GestaoDDD.Infra.Identity.Context;
using GestaoDDD.Infra.Identity.Model;
using GestaoDDD.Infra.IoC;
using GestaoDDD.MVC.App_Start;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WebActivatorEx;


[assembly: PostApplicationStartMethod(typeof(SimpleInjectorInitializer), "Initialize")]

namespace GestaoDDD.MVC.App_Start
{
  public class SimpleInjectorInitializer
  {
    public static void Initialize()
    {
      var container = new Container();
      container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

      // Chamada dos módulos do Simple Injector
       InitializeContainer(container);

      container.Register<ApplicationDbContext>(Lifestyle.Scoped);
      container.Register(() => new GestaoContext(), Lifestyle.Scoped);

      container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
      container.RegisterPerWebRequest<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
      container.RegisterPerWebRequest<ApplicationRoleManager>();
      container.RegisterPerWebRequest<ApplicationUserManager>();
      container.RegisterPerWebRequest<ApplicationSignInManager>();

      #region Candidato
      //container.Register<ICandidatoRepository, CandidatoRepository>(Lifestyle.Scoped);
      //container.Register<ICandidatoAppService, CandidatoAppService>(Lifestyle.Scoped);
      //container.Register<ICandidatoService, CandidatoService>(Lifestyle.Scoped);

      //container.Register<IDptoPoliciaRepository, DptoPoliciaRepository>(Lifestyle.Scoped);
      //container.Register<IDptoPoliciaAppService, DptoPoliciaAppService>(Lifestyle.Scoped);
      //container.Register<IDptoPoliciaService, DptoPoliciaService>(Lifestyle.Scoped);

      //container.Register<IDptoPoliciaRepository, DptoPoliciaRepository>(Lifestyle.Scoped);
      //container.Register<IDptoPoliciaAppService, DptoPoliciaAppService>(Lifestyle.Scoped);
      //container.Register<IDptoPoliciaService, DptoPoliciaService>(Lifestyle.Scoped);
      #endregion
      // Necessário para registrar o ambiente do Owin que é dependência do Identity
      // Feito fora da camada de IoC para não levar o System.Web para fora
      container.RegisterPerWebRequest(() =>
            {
              if (HttpContext.Current != null && HttpContext.Current.Items["owin.Environment"] == null && container.IsVerifying)
              {
                return new OwinContext().Authentication;
              }
              return HttpContext.Current.GetOwinContext().Authentication;

            });

      container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

      container.Verify();

      DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
    }

    private static void InitializeContainer(Container container)
    {
      BootStrapper.RegisterServices(container);
    }
  }
}