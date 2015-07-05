using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PomodoroOrders.Helpers
{
    //POR CONVENCION TODOS LAS CLASES HELPERS SON ESTATICAS
    public static class MisHelpers
    {
        //INTERFACE 
        public static IHtmlString LabelStrong(string content)
        {
            string htmlString = string.Format("<label><strong>{0}</strong></label>", content);

            return new HtmlString(htmlString);
        }
    }

    //POR EXTENSORES la posibilidade agregarle comportamiento a algun objeto
    public static class MisExtensores
    {
        //REVISAR CLASE TAG BUILDER
        public static IHtmlString LabelStrongExtended(this HtmlHelper helper, string content)
        {
            string htmlString = string.Format("<label><strong>{0}</strong></label>", content);

            return new HtmlString(htmlString);
        }
    }
}