using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using PomodoroOrders.Models;

namespace PomodoroOrders.Business
{
    public interface IRepositorio<T,  TElem>
    {
         List<SelectListItem> RegresaElementosDrop(IEnumerable<T> items);
    }

   
}
