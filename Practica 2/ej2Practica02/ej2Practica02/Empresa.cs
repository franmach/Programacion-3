using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2Practica02
{
    internal class Empresa
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public void getDatoEmpresa()
        {
            Console.WriteLine($"Empresa {Name} con Id {Id}");
        }
    }
}
