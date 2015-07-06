using PomodoroOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroOrders.Business
{
    class Repositorio_Orden
    {
        public Orden Crear()
        {
            Orden NuevaOrden = new Orden() { IdOrden = 1, IdCarrito = 1 };

            return NuevaOrden;
        }

        public List<Orden> ObtenerLista()
        {
            List<Orden> Lista_Ordenes = new List<Orden>();

            Lista_Ordenes.Add(new Orden { IdOrden = 1, IdCarrito = 1 });
            Lista_Ordenes.Add(new Orden { IdOrden = 2, IdCarrito = 2 });
            Lista_Ordenes.Add(new Orden { IdOrden = 3, IdCarrito = 3 });
            Lista_Ordenes.Add(new Orden { IdOrden = 4, IdCarrito = 4 });

            return Lista_Ordenes;
        }
    }
}
