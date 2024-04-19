using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej3Practica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 9, 7, 3, 5, 4, 6, 2, 8, 1 };

            for (var i = 0; i < valores.Count - 1; i++)
            {
                if (valores[i] > valores[i + 1])
                {
                    var valorTemporal = valores[i];

                    valores[i] = valores[i + 1];
                    valores[i + 1] = valorTemporal;
                    i = -1;
                }
            }

            foreach (var valorOrdenado in valores)
            {
                Console.WriteLine(valorOrdenado);
            }

            /*
             * ----- LINQ ------
            valores.OrderBy(v=>v).ToList().ForEach(v=>Console.WriteLine(v));
            */
        }
    }
}
