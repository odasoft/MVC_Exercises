using PomodoroOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroOrders.Business
{
    class Repositorio_Combo
    {
        public List<Combo> ObtenerCombos()
        {
            List<Combo> Lista_Combos = new List<Combo>();

            Lista_Combos.Add(new Combo { Id = 1, Nombre = "Combo #1 (Platillo + Sopa + Bebida)", Precio = 70 });
            Lista_Combos.Add(new Combo { Id = 2, Nombre = "Combo #2 (Platillo + Ensalada + Bebida)", Precio = 75 });
            Lista_Combos.Add(new Combo { Id = 3, Nombre = "Combo #3 (Platillo + Especial + Bebida)", Precio = 80 });

            return Lista_Combos;
        }
    }
}
