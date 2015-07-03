using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroOrders.Models
{
    public class Carrito
    {
        public int IdCarrito { get; set; }
        public int IdPlatillo{ get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; } 

    }
}
