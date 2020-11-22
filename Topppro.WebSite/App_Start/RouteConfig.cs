using System.Web.Mvc;
using System.Web.Routing;

namespace Topppro.WebSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("");
            routes.IgnoreRoute("world.html");
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "Modules_HiRes", // Route name
            //    url: "{controller}/Modules/HiRes", // URL with parameters
            //    defaults: new { controller = "Processors", action = "Modules_HiRes" } // Parameter defaults
            //);

            routes.MapRoute(
                name: "HiRes", // Route name
                url: "{culture}/{controller}/{id}/{name}/HiRes", // URL with parameters
                defaults: new { culture = Context.Current.Culture.TwoLetterISOLanguageName, action = "HiRes" }, // Parameter defaults
                constraints: new { culture = "[a-zA-Z]{2}" }
            ).RouteHandler = new LocalizedMvcRouteHandler();

            routes.MapRoute(
                name: "Software", // Route name
                url: "{culture}/{controller}/{id}/{name}/Software", // URL with parameters
                defaults: new { culture = Context.Current.Culture.TwoLetterISOLanguageName, action = "Software" }, // Parameter defaults
                constraints: new { culture = "[a-zA-Z]{2}" }
            ).RouteHandler = new LocalizedMvcRouteHandler(); ;

            routes.MapRoute(
                name: "Detail", // Route name
                url: "{culture}/{controller}/{id}/{name}", // URL with parameters
                defaults: new { culture = Context.Current.Culture.TwoLetterISOLanguageName, action = "Detail" }, // Parameter defaults
                constraints: new { culture = "[a-zA-Z]{2}" }
            ).RouteHandler = new LocalizedMvcRouteHandler(); ;

            routes.MapRoute(
                name: "Default",
                url: "{culture}/{controller}/{action}/{id}",
                defaults: new { culture = Context.Current.Culture.TwoLetterISOLanguageName, controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { culture = "[a-zA-Z]{2}" }
            ).RouteHandler = new LocalizedMvcRouteHandler(); ;
        }
    }
}