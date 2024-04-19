using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona {Nombre="Juan", Edad=25, Ciudad = "Lima"},
                new Persona {Nombre="Maria", Edad=30, Ciudad = "Bogota"},
                new Persona {Nombre="Pedro", Edad=35, Ciudad = "Madrid"},
                new Persona {Nombre="Ana", Edad=20, Ciudad = "Lima"},
                new Persona {Nombre="Jose", Edad=40, Ciudad = "Buenos Aires"},

            };

            //Dos formas de hacerlo
            //1
            personas.Where(p => p.Edad < 25 && p.Ciudad == "Lima").ToList().OrderBy(p => p.Nombre).ToList().ForEach(p => Console.WriteLine($"{p.Nombre} ({p.Edad}) años")) ;
            //2
            var consulta = from p in personas where p.Edad < 25 && p.Ciudad == "Lima" orderby p.Nombre descending select new { p.Nombre, p.Edad };
            foreach( var persona in consulta)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }

            //Ej 1 - i
            personas.Where(p => p.Edad >= 30 && p.Ciudad == "Bogota").ToList().ForEach(p => Console.WriteLine(p.Nombre));

            //Ej 1 - ii
            personas.OrderBy(p => p.Edad).Where(p => p.Edad >= 25 && p.Edad <= 35).ToList().ForEach(p => Console.WriteLine($"{p.Nombre} ({p.Edad} años)"));
           
         


        }
    } 
}
