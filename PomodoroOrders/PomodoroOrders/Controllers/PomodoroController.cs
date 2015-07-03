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
            Repositorio_Bebida rb = new Repositorio_Bebida();
            var itemsBebidas = rb.RegresaBebidas();
            OrdenViewModel ovm = new OrdenViewModel();
            ovm.Bebidas = RegresaItems();

            //ViewBag.Bebidas = itemsBebidas;

            return View(ovm);
        }
        public List<SelectListItem> RegresaItems()
        {
            Repositorio_Bebida rb = new Repositorio_Bebida();
            var listaBebidas = rb.ObtenerBebidas();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var x in listaBebidas)
            {
                items.Add(new SelectListItem { Text = string.Format("{0} (${1})", x.NombreBebida, x.Precio.ToString()), Value = x.Id.ToString() });
            }

            return items;
        }

       
    }
}