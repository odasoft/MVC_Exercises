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

            Lista_Combos.Add(new Combo { Id = 1, NombreCombo = "Combo #1 (Platillo + Sopa + Bebida)", Precio = 70 });
            Lista_Combos.Add(new Combo { Id = 2, NombreCombo = "Combo #2 (Platillo + Ensalada + Bebida)", Precio = 75 });
            Lista_Combos.Add(new Combo { Id = 3, NombreCombo = "Combo #3 (Platillo + Especial + Bebida)", Precio = 80 });

            return Lista_Combos;
        }
    }
}
