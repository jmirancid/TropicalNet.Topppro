using System.Web.Mvc;

namespace Topppro.WebSite
{
    public class LocalizedViewEngine : RazorViewEngine
    {
        public LocalizedViewEngine() :
            base()
        { }

        public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            var controllerName = (string)controllerContext.RouteData.Values["controller"];
            var culture = (string)controllerContext.RouteData.Values["culture"];
            //var culture = Topppro.Context.Current.Culture.TwoLetterISOLanguageName;

            var viewResult = base.FindPartialView(controllerContext, partialViewName + "." + culture, useCache);

            if (viewResult.View == null)
                viewResult = base.FindPartialView(controllerContext, partialViewName, useCache);

            return viewResult;
        }

        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            var controllerName = (string)controllerContext.RouteData.Values["controller"];
            var culture = (string)controllerContext.RouteData.Values["culture"];
            //var culture = Topppro.Context.Current.Culture.TwoLetterISOLanguageName;

            var viewResult = base.FindView(controllerContext, viewName + "." + culture, masterName, useCache);

            if (viewResult.View == null)
                viewResult = base.FindView(controllerContext, viewName, masterName, useCache);

            return viewResult;
        }
    }
}