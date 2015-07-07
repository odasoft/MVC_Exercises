using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using PomodoroOrders.Models;

namespace PomodoroOrders.Business
{
    public class Repositorio_Bebida: IRepositorio<Bebida,List<SelectListItem>>
    {
        public List<Bebida> ObtenerBebidas()
        {
            List<Bebida> Lista_Bebidas = new List<Bebida>();

            Lista_Bebidas.Add(new Bebida { Id = 1, Nombre = "Te Limon", Precio = 10 });
            Lista_Bebidas.Add(new Bebida { Id = 2, Nombre = "Agua de Fresa", Precio = 12 });
            Lista_Bebidas.Add(new Bebida { Id = 3, Nombre = "Soda", Precio = 15 });

            return Lista_Bebidas;
        }

        public IEnumerable<Bebida> RegresaBebidas()
        {
            var Lista_Bebidas = new List<Bebida>();

            Lista_Bebidas.Add(new Bebida { Id = 1, Nombre= "Te Limon", Precio = 10 });
            Lista_Bebidas.Add(new Bebida { Id = 2, Nombre= "Agua de Fresa", Precio = 12 });
            Lista_Bebidas.Add(new Bebida { Id = 3, Nombre= "Soda", Precio = 15 });

            return Lista_Bebidas;
        }

        public List<SelectListItem> RegresaElementosDrop(IEnumerable<Bebida> bebidas)
        {
            List<SelectListItem> items =  bebidas
                .Select(bebida => new SelectListItem {Text = bebida.Nombre, Value = bebida.Id.ToString()})
                .ToList();
            return items;
        }
    }
}
