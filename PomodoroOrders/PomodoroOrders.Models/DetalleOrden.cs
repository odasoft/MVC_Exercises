﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroOrders.Models
{
    public class DetalleOrden
    {
        public int IdOrden { get; set; } 
        public DateTime fecha { get; set; }
        public decimal Total { get; set; } 
    }
}