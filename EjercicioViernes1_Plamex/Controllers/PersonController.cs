using EjercicioViernes1_Plamex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioViernes1_Plamex.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarLista()
        {
            var lAsistencia = Person_Repository.GetList();

            if (TempData["ListaAsistencia"] != null)
            {
                var ListaAsistencia = TempData["ListaAsistencia"] as List<Person>;

                foreach (var item in ListaAsistencia)
                {
                    lAsistencia.Add(item);
                }
            }

            ViewBag.ListaAsistencia = lAsistencia;
            TempData["ListaAsistencia"] = lAsistencia;

            //Este declaracion es automatica no se ocupa hacer
            //TempData.Keep("ListaAsistencia");

            return View();
        }

        public ActionResult RedireccionarLista()
        {
            var lAsistencia = Person_Repository.GetList();

            ViewBag.ListaAsistencia = lAsistencia;

            TempData["ListaAsistencia"] = lAsistencia;

            return RedirectToAction("ComprobarLista", "Person");
        }

        public ActionResult ComprobarLista()
        {
            if (TempData["ListaAsistencia"] != null)
            {
                var ListaAsistencia = TempData["ListaAsistencia"] as List<Person>;

                TempData["ListaAsistencia"] = ListaAsistencia;

                //Este declaracion es automatica no se ocupa hacer
                //TempData.Keep("ListaAsistencia");

                ViewBag.Resultado = ListaAsistencia.Count();
            }
            else
            {
                ViewBag.Resultado = "0";
            }

            return View();
        }

    }
}