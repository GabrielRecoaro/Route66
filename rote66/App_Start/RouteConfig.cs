using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace rote66
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Noticia Especifica",
               url: "Noticias/{categoria}/{Titulo}-{noticiaId}",
               defaults: new { controller = "Home", action = "MostraNoticia", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Categoria Especifica",
               url: "Noticias/{categoria}",
               defaults: new { controller = "Home", action = "MostraCategoria", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Todas as noticias",
               url: "Noticias/",
               defaults: new { controller = "Home", action = "Noticias", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"rote66.Controllers"}
            );

           
        }
    }
}
