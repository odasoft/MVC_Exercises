
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using PomodoroOrders.Models;

namespace PomodoroOrders.Business
{
    public class Repositorio_Platillo:IRepositorio<Platillo, List<SelectListItem>>
    {
        public List<Platillo> ObtenerPlatillos()
        {
            List<Platillo> Lista_Platillos = new List<Platillo>();

            Lista_Platillos.Add(new Platillo { Id = 1, Nombre = "Wrap", Precio = 30 });
            Lista_Platillos.Add(new Platillo { Id = 2, Nombre = "Sandwich", Precio = 40 });
            Lista_Platillos.Add(new Platillo { Id = 3, Nombre = "Ensalada", Precio = 42 });
            Lista_Platillos.Add(new Platillo { Id = 4, Nombre = "Comida del dia (Incluye Bebida)", Precio = 80 });

            return Lista_Platillos;
        }

        public List<SelectListItem> RegresaElementosDrop(IEnumerable<Platillo> platillos)
        {
            List<SelectListItem> items = platillos
               .Select(platillo => new SelectListItem { Text = platillo.Nombre, Value = platillo.Id.ToString() })
               .ToList();
            return items;
        }
    }
}
