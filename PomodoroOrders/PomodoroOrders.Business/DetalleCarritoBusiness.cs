using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomodoroOrders.Models;

namespace PomodoroOrders.Business
{
    public class DetalleCarritoBusiness
    {
        public DetalleCarrito InsertaDetalleCarrito(Carrito c, Producto p, int cantidad, TipoProducto tipo)
        {
            return new DetalleCarrito { IdCarrito = c.IdCarrito, IdProducto = p.Id, Precio = p.Precio, Cantidad = cantidad, TipoProducto = tipo };
        }
    }
}
