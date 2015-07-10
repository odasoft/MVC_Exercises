using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PomodoroOrders.Models;

namespace PomodoroOrders.Data
{
    public class PomodoroDbContext:DbContext
    {
        public PomodoroDbContext():base("PomodoroConnection")
        {
            
        }
        //Propiedades de modelos...
       // public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Bebida> Bebidas{ get; set; }
        //public DbSet<Combo> Combos { get; set; }
        //public DbSet<DetalleCarrito> DetallesCarrito{ get; set; }
        //public DbSet<DetalleOrden> DetallesOrden{ get; set; }
        //public DbSet<Orden> Ordenes{ get; set; }
        //public DbSet<Platillo> Platillos{ get; set; }

    }
}
