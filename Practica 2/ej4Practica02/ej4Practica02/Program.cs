using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4Practica02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sumaTotal = 0;

            foreach( var valor in valores )
            {
                sumaTotal = sumaTotal+valor;
            }

            //Console.WriteLine($"La suma total es {sumaTotal}");

            // a)
            Console.WriteLine($"La suma total es {valores.Sum(x => x)}");




            int sumaTotalValoresPares = 0;
            foreach( var valor in valores)
            {
                if (valor % 2 == 0)
                {
                    sumaTotalValoresPares= sumaTotalValoresPares+ valor;
                }
            }
            //Console.WriteLine($"La suma total de los valores pares es {sumaTotalValoresPares}");

            // b)
            Console.WriteLine($"La suma total de los valores pares es {valores.Where(x => x%2==0).Sum()}");

        }
    }
}
