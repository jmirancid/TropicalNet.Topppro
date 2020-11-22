using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Topppro.WebSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Preload cached resources
            ProductAssets.Preload();

            // Custom View Engine
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new LocalizedViewEngine());
        }
    }
}
