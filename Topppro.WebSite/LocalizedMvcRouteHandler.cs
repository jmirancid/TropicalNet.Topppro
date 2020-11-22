using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Topppro.WebSite
{
    public class LocalizedMvcRouteHandler : MvcRouteHandler
    {
        protected override IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            //string cultureName = "en";
            string cultureName =
                Topppro.Context.Current.Culture.TwoLetterISOLanguageName;

            if (requestContext.RouteData.Values.ContainsKey("culture"))
                cultureName = requestContext.RouteData.Values["culture"].ToString().ToLower();

            if (IsCultureAvailable(cultureName) && IsCultureDistinct(cultureName))
            {
                var ci = CultureInfo.GetCultureInfo(cultureName);
                // var ci = new CultureInfo(cultureName);

                if (ci != null)
                    Topppro.Context.Current.Culture = ci;
            }

            //Thread.CurrentThread.CurrentUICulture = ci;
            //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ci.Name);

            return base.GetHttpHandler(requestContext);
        }

        private bool IsCultureAvailable(string cultureName)
        {
            return CultureInfo.GetCultures(CultureTypes.NeutralCultures).Any(c => c.TwoLetterISOLanguageName == cultureName);
        }

        private bool IsCultureDistinct(string cultureName)
        {
            return Topppro.Context.Current.Culture.TwoLetterISOLanguageName != cultureName;
        }
    }
}