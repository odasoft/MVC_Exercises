
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomodoroOrders.Models;

namespace PomodoroOrders.Business
{
    class Repositorio_Platillo
    {
        public List<Platillo> ObtenerPlatillos()
        {
            List<Platillo> Lista_Platillos = new List<Platillo>();

            Lista_Platillos.Add(new Platillo { Id = 1, PlatilloNombre = "Wrap", Precio = 30 });
            Lista_Platillos.Add(new Platillo { Id = 2, PlatilloNombre = "Sandwich", Precio = 40 });
            Lista_Platillos.Add(new Platillo { Id = 3, PlatilloNombre = "Ensalada", Precio = 42 });
            Lista_Platillos.Add(new Platillo { Id = 4, PlatilloNombre = "Comida del dia (Incluye Bebida)", Precio = 80 });

            return Lista_Platillos;
        }
    }
}
