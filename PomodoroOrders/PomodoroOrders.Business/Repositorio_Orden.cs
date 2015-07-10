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
        public Orden CrearOrden ()
        {
            Orden NuevaOrden = new Orden();

            return NuevaOrden;
        }
    }
}
