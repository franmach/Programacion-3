using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej5Practica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

            int sumaTotalValoresParesMayoresAOcho = 0;
            int sumaTotalValoresParesMenoresAOcho = 0;

            foreach(var valor in valores)
            {
                if(valor%2==0)
                {
                    if(valor>8)
                    {
                        sumaTotalValoresParesMayoresAOcho = sumaTotalValoresParesMayoresAOcho + valor;
                    }
                    else
                    {
                        sumaTotalValoresParesMenoresAOcho = sumaTotalValoresParesMenoresAOcho + valor;
                    }
                }
            }

            Console.WriteLine($"La suma total de los pares mayores a ocho es {sumaTotalValoresParesMayoresAOcho}");
            Console.WriteLine($"La suma total de los pares menores a ocho es {sumaTotalValoresParesMenoresAOcho}");

            
            Console.WriteLine($"La suma total de los pares mayores a ocho es {valores.Where(v => v % 2 == 0 && v > 8).Sum()}");
            Console.WriteLine($"La suma total de los pares menores a ocho es {valores.Where(v => v % 2 == 0 && v < 8).Sum()}");

        }
    }
}
