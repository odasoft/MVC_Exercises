using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomodoroOrders.Data;
using PomodoroOrders.Models;

namespace PomodoroOrders.DbTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var nuevaBebida = new Bebida {Id = 1, Nombre = "Te", Precio = 50.12m};
            var context = new PomodoroDbContext();
            context.Bebidas.Add(nuevaBebida);
            context.SaveChanges();
            Console.WriteLine("Bebida insertada");
            Console.Read();
        }
    }
}
