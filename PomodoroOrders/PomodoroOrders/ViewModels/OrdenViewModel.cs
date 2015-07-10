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
        public Platillo Platillos { get; set; }
        public Combo Combos { get; set; }
        public List<SelectListItem> Bebidas { get; set; }
    }
}