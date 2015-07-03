using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomodoroOrders.Models;

namespace PomodoroOrders.Business
{
    public interface IRepositorio
    {
         IEnumerable<Bebida> RegresaBebidas();
    }
}
