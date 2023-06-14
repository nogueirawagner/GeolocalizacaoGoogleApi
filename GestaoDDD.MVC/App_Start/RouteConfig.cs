using System.Web.Mvc;
using System.Web.Routing;

namespace GestaoDDD.MVC
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


      routes.MapRoute(
      name: "Admin",
      url: "Admin",
      defaults: new
      {
        controller = "Admin",
        action = "Index"
      });

      //routes.MapRoute(
      //    name: "Cadastro",
      //    url: "{controller}/{action}/{id}",
      //    defaults: new { controller = "Candidato", action = "BuscaCandidatos", id = UrlParameter.Optional }
      //);

      routes.MapRoute(
               name: "Cadastro",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "DepartamentoPolicia", action = "BuscaDelegacias", id = UrlParameter.Optional }
           );

      routes.MapRoute(
               name: "Estatisticas",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Estatisticas", action = "EstatisticasDF", id = UrlParameter.Optional }
           );






      //a rota tava Prestador, create.
    }
  }
}