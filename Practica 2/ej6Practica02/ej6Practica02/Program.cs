using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej6Practica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una letra minuscula (desde a hasta f) para saber cual es la siguiente" +
                "letra del abecedario");
            string letra = Console.ReadLine();

            switch(letra)
            {
                case "a":
                    Console.WriteLine("La siguiente letra del abecedario es B !!");
                    break;
                case "b":
                    Console.WriteLine("La siguiente letra del abecedario es C !!");
                    break;
                case "c":
                    Console.WriteLine("La siguiente letra del abecedario es D !!");
                    break;
                case "d":
                    Console.WriteLine("La siguiente letra del abecedario es E !!");
                    break;
                case "e":
                    Console.WriteLine("La siguiente letra del abecedario es F !!");
                    break;
                case "f":
                    Console.WriteLine("La siguiente letra del abecedario es G !!");
                    break;

            }
        }
    }
}
