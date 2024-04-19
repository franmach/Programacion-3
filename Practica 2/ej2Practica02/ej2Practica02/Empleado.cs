using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2Practica02
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cargo {  get; set; }
        public int Salario {  get; set; }
        public int EmpresaId {  get; set; }

        public void getDatosEmpleado()
        {
            Console.WriteLine($"Empleado {Name} con Id {Id}, cargo {Cargo}, salario {Salario} y pertenece a la empresa {EmpresaId}");
        }

        
    }
}
