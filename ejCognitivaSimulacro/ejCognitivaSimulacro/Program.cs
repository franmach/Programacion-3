using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejCognitivaSimulacro
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Nota { get; set; }

        public Alumno(string nombre, int edad, int nota)
        {
            Nombre = nombre;
            Edad = edad;
            Nota = nota;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>() {
                new Alumno("Eva", 26, 6),
                new Alumno("Ana", 18, 7),
                new Alumno("Rosa", 22, 5),
                new Alumno("Ricardo", 30, 9),
                new Alumno("Felipe", 45, 2),
                new Alumno("Peter", 19, 5),
                new Alumno("Lala", 26,16),
                new Alumno("Tania",19,8),
                new Alumno("Stephanie",33,6),
                new Alumno("Agustin",50,7),
                new Alumno("Mauricio",31,12)
        };

            var alumnosExonerados = new List<Alumno>();

            //foreach (var alumno in alumnos) //-----> +1
            //{
            //    if (alumno.Nota > 6)//------> +1 --> +1 por anidacion
            //    {
            //        if (alumno.Nombre.Length > 4)//------> +1 -->+1 por anidacion
            //        {
            //            alumnosExonerados.Add(alumno);
            //        }
            //    }
            //} //----- total = 5
            //SOLUCION LINQ
            alumnos.Where(a => a.Nota > 6 && a.Nombre.Length > 4).ToList().ForEach(a => alumnosExonerados.Add(a));
            //


            //for (var i = 0; i < alumnosExonerados.Count - 1; i++)//----> +1
            //{
            //    if (alumnosExonerados[i].Edad > alumnosExonerados[i + 1].Edad) //----> +1 -->+1 por anidacion
            //    {
            //        var alumnoAuxiliar = alumnosExonerados[i];
            //        alumnosExonerados[i] = alumnosExonerados[i + 1];
            //        alumnosExonerados[i + 1] = alumnoAuxiliar;

            //        i -= 1;
            //    }
            //}//----- total = 3
             //SOLUCION LINQ
            alumnosExonerados.OrderBy(a => a.Edad).ToList().ForEach(a => Console.WriteLine(a.Nombre + a.Edad));

            //foreach (var alumno in alumnosExonerados)//---- total = 1
            //{
            //    Console.WriteLine($"Nombre: {alumno.Nombre} - Edad: {alumno.Edad} - Nota: {alumno.Nota}");
            //}
            //SOLUCION LINQ
            alumnosExonerados.ForEach(a => Console.WriteLine($"Nombre: {a.Nombre} - Edad: {a.Edad} - Nota: {a.Nota}"));
            //
        }
    }
}
