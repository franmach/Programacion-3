using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerEjEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nombre de la base de datos: PruebaEntity -- Me conecto a la base de datos
            using (pruebaEntityEntities db = new pruebaEntityEntities())
            {
                //Tabla Estudiante (clase), cada alumno es un objeto creado
                var lst = db.Estudiante;

                foreach (var alumno in lst)
                {
                    //Lista nombre de cada objeto alumno 
                    Console.WriteLine(alumno.nombre);
                }


                var estudiantesMayores = db.Estudiante
                                .Where(e => e.edad > 18)
                                .OrderBy(e => e.nombre)
                                .ToList();
                foreach (var estudiante in estudiantesMayores)
                {
                    Console.WriteLine($"ID: {estudiante.id}, Nombre: {estudiante.nombre}, Edad: {estudiante.edad}");
                }
            }
        }

    }
}
