using System.Web.Mvc;
using System.Web.Mvc.Html;
using Topppro.WebSite.Models;

namespace Topppro.WebSite.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString Article(
            this HtmlHelper htmlHelper, string culture, string image, string title, string content, string info = null, string date = null)
        {
            if (Topppro.Context.Current.Culture.TwoLetterISOLanguageName == culture)
                return Article(htmlHelper, image, title, content, info, date);

            return null;
        }

        public static MvcHtmlString Article(
            this HtmlHelper htmlHelper, string image, string title, string content, string info = null, string date = null)
        {
            var model = 
                new Article() { Image = image, Title = title, Content = content, Info = info, Date = date };

            return htmlHelper.Partial("_Article", model);
        }
    }
}