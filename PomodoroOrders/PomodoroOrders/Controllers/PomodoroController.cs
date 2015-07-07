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
            Repositorio_Orden o = new Repositorio_Orden();
            
            return View(o.ObtenerLista());
        }

        public ActionResult VistaParcial()
        {
            return PartialView("_VistaParcial");
        }


        [HttpPost]
        public ActionResult RecibirOrden(OrdenViewModel Seleccion)
        {
            Repositorio_Carrito c = new Repositorio_Carrito();
            return PartialView("_VistaParcial", c.Agregar(Seleccion));
        }



    }
}