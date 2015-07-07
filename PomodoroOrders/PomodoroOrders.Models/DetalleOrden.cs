using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroOrders.Models
{
    public class DetalleOrden
    {
        public int IdDetalleOrden { get; set; }
        public int IdOrden { get; set; }
        public int IdCarrito { get; set; }
    }
}
