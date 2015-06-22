using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioViernes1_Plamex.Models
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Boolean Assistance { get; set; }

        public List<Person> GetList ()
        {
            List<Person> lPersons = new List<Person>();

            Random rd = new Random();

            lPersons.Add(new Person { Name = "Domingo Ramirez", Date = DateTime.Now.AddDays(rd.Next(10)), Assistance = true });
            lPersons.Add(new Person { Name = "Brizna Rodriguez", Date = DateTime.Now.AddDays(rd.Next(10)), Assistance = false });
            lPersons.Add(new Person { Name = "Ezequiel Ramirez", Date = DateTime.Now.AddDays(rd.Next(10)), Assistance = true });
            lPersons.Add(new Person { Name = "Daniel Medrano", Date = DateTime.Now.AddDays(rd.Next(10)), Assistance = false });

            return lPersons;
        }
    }
}