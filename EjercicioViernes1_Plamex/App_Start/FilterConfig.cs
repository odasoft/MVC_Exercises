using System.Web;
using System.Web.Mvc;

namespace EjercicioViernes1_Plamex
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
