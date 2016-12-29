
using System.Web.Mvc;
using System.Web.Routing;

namespace TEST
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{Controller}/{Action}",
                defaults: new { Controller = "Home", Action = "Index", end = UrlParameter.Optional }
            );

            routes.MapMvcAttributeRoutes();            

        }
    }
}
