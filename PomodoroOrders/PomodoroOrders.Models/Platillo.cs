using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroOrders.Models
{
    public class Platillo
    {
        public int Id { get; set; }
        public string PlatilloNombre { get; set; }
        public decimal Precio { get; set; }
    }
}
