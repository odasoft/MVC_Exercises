using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PomodoroOrders.Business;
using PomodoroOrders.Models;
using PomodoroOrders.ViewModels;

namespace PomodoroOrders.Controllers
{
    public class PomodoroController : Controller
    {
        // GET: Pomodoro
        public ActionResult Index()
        {
            var rb = new Repositorio_Bebida();
            var rp = new Repositorio_Platillo();
            var rc = new Repositorio_Combo();

            var ovm = new OrdenViewModel();

            ovm.Bebidas =  rb.RegresaElementosDrop(rb.ObtenerBebidas());
            ovm.Platillos = rp.RegresaElementosDrop(rp.ObtenerPlatillos());
            ovm.Combos = rc.RegresaElementosDrop(rc.ObtenerCombos());
            
            return View(ovm);
        }

        public ActionResult VistaParcial()
        {
            return PartialView("_VistaParcial");
        }
    }
}