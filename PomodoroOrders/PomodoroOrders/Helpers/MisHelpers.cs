using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PomodoroOrders.Helpers
{
    public static class MisHelpers
    {
        public static IHtmlString LabelStrong(string content)
        {
            string htmlString = string.Format("<label><strong>{0}</strong></label>",content);
            return new HtmlString(htmlString);
        }
    }
    //public static class MisExtensores
    //{
    //    public static IHtmlString LabelStrongExtended(string content)
    //    {
    //        string htmlString = string.Format("<label><strong>{0}</strong></label>", content);
    //        return new HtmlString(htmlString);
    //    }
    //}

    public static class MisExtensores
    {
        public static IHtmlString LabelStrongExtended(this HtmlHelper helper, string   content)
        {
            string htmlString = string.Format("<label><strong>{0}</strong></label>", content);
            return new HtmlString(htmlString);
        }
    }
}