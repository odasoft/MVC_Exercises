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


        //[HttpPost]
        //public ActionResult RecibirOrden(OrdenViewModel Seleccion)
        //{
        //    Repositorio_Carrito c = new Repositorio_Carrito();
        //    //return PartialView("_VistaParcial", c.Agregar(Seleccion));
        //}

        public ActionResult AgregaraCarrito()
        {
            Repositorio_Carrito rc = new Repositorio_Carrito();
            DetalleCarritoBusiness dc = new DetalleCarritoBusiness();
            List<Producto> productos = new List<Producto>();

            //simulando un platillo, cantidad
            //simulando una bebida, cantidad 
            //simulando un combo , cantidad
            Platillo p = new Platillo();
            p.Id = 2;
            p.Nombre="Sandwich Pollo";
            p.Precio=5;
            
            Bebida b = new Bebida();
            b.Id = 2;
            b.Nombre="Te";
            b.Precio=15;

            productos.Add(p);
            productos.Add(b);

            var carrito = new Carrito { IdCarrito = 1, FechaCreacion = DateTime.Now };
            rc.Agregar(carrito);

            foreach (var producto in productos)
            {
                dc.InsertaDetalleCarrito(carrito, producto, 3, TipoProducto.Platillo);

            }
           // return RedirectToAction("Index", "Pomodoro");

            
          


          
            return Content("Probando Insert...");
        }


    }
}