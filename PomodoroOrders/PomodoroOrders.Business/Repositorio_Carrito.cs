using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomodoroOrders.Models;

namespace PomodoroOrders.Business
{
    public class Repositorio_Carrito
    {
        public Carrito CrearCarrito()
        {
            return new Carrito { CarritoId = 1, FechaCreacion = DateTime.Now };
        }
    }
}
