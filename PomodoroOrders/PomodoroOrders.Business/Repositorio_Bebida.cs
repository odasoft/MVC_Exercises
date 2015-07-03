using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomodoroOrders.Models;

namespace PomodoroOrders.Business
{
    public class Repositorio_Bebida:IRepositorio
    {
        public List<Bebida> ObtenerBebidas()
        {
            List<Bebida> Lista_Bebidas = new List<Bebida>();

            Lista_Bebidas.Add(new Bebida { Id = 1, NombreBebida = "Te Limon", Precio = 10 });
            Lista_Bebidas.Add(new Bebida { Id = 2, NombreBebida = "Agua de Fresa", Precio = 12 });
            Lista_Bebidas.Add(new Bebida { Id = 3, NombreBebida = "Soda", Precio = 15 });

            return Lista_Bebidas;
        }

        public IEnumerable<Bebida> RegresaBebidas()
        {
            var Lista_Bebidas = new List<Bebida>();

            Lista_Bebidas.Add(new Bebida { Id = 1, NombreBebida = "Te Limon", Precio = 10 });
            Lista_Bebidas.Add(new Bebida { Id = 2, NombreBebida = "Agua de Fresa", Precio = 12 });
            Lista_Bebidas.Add(new Bebida { Id = 3, NombreBebida = "Soda", Precio = 15 });

            return Lista_Bebidas;
        }
    }
}
