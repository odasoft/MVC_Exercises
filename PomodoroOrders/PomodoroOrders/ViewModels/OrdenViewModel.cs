using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PomodoroOrders.Models;
using System.Web.Mvc;
namespace PomodoroOrders.ViewModels
{
    public class OrdenViewModel
    {
        public List<SelectListItem> Platillos { get; set; }
        public List<SelectListItem>Combos { get; set; }
        public List<SelectListItem> Bebidas { get; set; }
        public Carrito Carrito { get; set; }

    }
}