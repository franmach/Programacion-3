using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ej2Practica02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();
            Console.WriteLine("Promedios por empresas \n***************************");
            ce.promedioSalario();
            Console.WriteLine("");

            Console.WriteLine("Peces gordos \n***************************");
            ce.getCeo("CEO");
            Console.WriteLine("");

            Console.WriteLine("Plantilla \n***************************");
            ce.getEmpleadosOrdenados();
            Console.WriteLine("");

            Console.WriteLine("Plantilla ordenada por salario \n***************************");
            ce.getEmpleadosOrdenadosSegun();
            Console.WriteLine("");

            Console.WriteLine("\n Ingrese la empresa: (entero de 1 a 3) \n1 para iAlpha \n2 para Udelar \n3 para SpaceZ");
            string _Id = Console.ReadLine();
            try
            {
                int _Empresa = int.Parse(_Id);
                ce.getEmpleadosEmpresa(_Empresa);
            }
            catch
            {
                Console.WriteLine("Ha introducido un Id erroneo. Debe ingresar un numero entero");
            }


            Console.WriteLine("\n************************************\n*****Consultas LINQ***** \n************************************");

            //1)
            int cant = 0;
            ce.listaEmpleados.Where(e => e.EmpresaId == 1 && e.Cargo=="CEO").ToList().ForEach( e=>cant++);
            Console.WriteLine($"Cantidad de CEO en la empresa con id 1: " +cant );
            Console.WriteLine("");

            //2)
            Console.WriteLine("El emleado que gana mas:");
            ce.listaEmpleados.OrderByDescending(e => e.Salario).FirstOrDefault().getDatosEmpleado();  
            Console.WriteLine("");

            //3)
            Console.WriteLine("Empleados que ganan mas de 2200:");
            ce.listaEmpleados.Where(e => e.Salario > 2200).ToList().ForEach(e => Console.WriteLine($"{e.Name} Salario: {e.Salario}"));
            Console.WriteLine("");

            //4)
            Console.WriteLine("Empleado que ganan mas por cargo");
            ce.listaEmpleados
                .GroupBy(e => e.Cargo) // Agrupar los empleados por su cargo
                .Select(group =>
                {
                    // Dentro de cada grupo, seleccionar al empleado con el salario más alto
                    var empleadoMejorRemunerado = group.OrderByDescending(e => e.Salario).FirstOrDefault();
                    return empleadoMejorRemunerado;
                })
                .ToList().ForEach(e=>e.getDatosEmpleado());
            Console.WriteLine("");

            //5)
            Console.WriteLine("Empleado que ganan mas por empresa");
            ce.listaEmpleados
                .GroupBy(e => e.EmpresaId) // Agrupar los empleados por su cargo
                .Select(group =>
                {
                    // Dentro de cada grupo, seleccionar al empleado con el salario más alto
                    var empleadoMejorRemunerado = group.OrderByDescending(e => e.Salario).FirstOrDefault();
                    return empleadoMejorRemunerado;
                })
                .ToList().ForEach(e => e.getDatosEmpleado());
            Console.WriteLine("\n**********************************************************");

        }
    }
}
