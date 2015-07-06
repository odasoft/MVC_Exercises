using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PomodoroOrders.Business;
using PomodoroOrders.Models;

namespace PomodoroOrders.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Repositorio_Orden o = new Repositorio_Orden();          

            return View(o.ObtenerLista());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}