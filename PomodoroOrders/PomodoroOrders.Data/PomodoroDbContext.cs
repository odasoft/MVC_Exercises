using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PomodoroOrders.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PomodoroOrders.Data
{
    public class PomodoroDbContext:DbContext
    {
        public PomodoroDbContext():base("PomodoroConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        //Propiedades de modelos...
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<DetalleCarrito> DetallesCarrito { get; set; }
        public DbSet<DetalleOrden> DetallesOrden { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}
