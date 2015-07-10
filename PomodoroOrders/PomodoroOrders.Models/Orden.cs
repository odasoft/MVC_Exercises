using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroOrders.Models
{
    public class Orden
    {
        public int OrdenId { get; set; }
        public int IdCarrito { get; set; }
        public int IdAsociado { get; set; }
 
    }
}
