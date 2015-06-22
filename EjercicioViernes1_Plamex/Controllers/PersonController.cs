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
            Person oPerson = new Person();
            var lAsistencia = oPerson.GetList();

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

            return View();
        }

        public ActionResult RedireccionarLista()
        {
            Person oPerson = new Person();

            var lAsistencia = oPerson.GetList();

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