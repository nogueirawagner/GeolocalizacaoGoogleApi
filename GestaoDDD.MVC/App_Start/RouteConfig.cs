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
            name: "Contato",
            url: "Contato",
            defaults: new
            {
                controller = "Contato",
                action = "Create",
                id = UrlParameter.Optional
            });

            routes.MapRoute(
                name: "Cadastro",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Candidato", action = "Create", id = UrlParameter.Optional }
            );


            

           

            //a rota tava Prestador, create.
        }
    }
}