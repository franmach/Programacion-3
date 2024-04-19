using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2Practica02
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empleado> listaEmpleados;
        public List<Empresa> listaEmpresas;

        public ControlEmpresasEmpleados()
        {
            listaEmpleados = new List<Empleado>
            {
                new Empleado {Id = 1, Name= "Gonzalo", Cargo="CEO", EmpresaId= 1, Salario=3000 },
                new Empleado {Id = 2, Name= "JuanC", Cargo="Desarrollador", EmpresaId= 1, Salario=2000 },
                new Empleado {Id = 3, Name= "JuanR", Cargo="Desarrollador", EmpresaId= 1, Salario=2000 },
                new Empleado {Id = 4, Name= "Daniel", Cargo="Desarrollador", EmpresaId= 1, Salario=2000 },
                new Empleado {Id = 5, Name= "GonzaloT", Cargo="CEO", EmpresaId= 2, Salario=2000 },
                new Empleado {Id = 6, Name= "Leonardo", Cargo="CEO", EmpresaId= 1, Salario=4500 },
                new Empleado {Id = 1, Name= "Gonzalo", Cargo="CEO", EmpresaId= 3, Salario=3000 },
                new Empleado {Id = 6, Name= "Leonardo", Cargo="CEO", EmpresaId= 3, Salario=3000 }


            };
            listaEmpresas = new List<Empresa>
            {
                new Empresa {Id=1, Name="IAlpha"},
                new Empresa {Id=2, Name="Udelar"},
                new Empresa {Id=3, Name="Spacez"}
            };

        }
        
        
        // Getters

        public void getCeo(string cargo)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              where empleado.Cargo == cargo
                                              select empleado;

            foreach (Empleado e in empleados)
            {
                e.getDatosEmpleado();
            }
        }
        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Name select empleado;

            foreach (Empleado e in empleados)
            {
                e.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenadosSegun()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Salario select empleado;

            foreach (Empleado e in empleados)
            {
                e.getDatosEmpleado();
            }
        }

        public void getEmpleadosEmpresa(int _empresa)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              join empresa in listaEmpresas on empleado.EmpresaId equals empresa.Id
                                              where empresa.Id == _empresa
                                              select empleado;
            foreach (Empleado e in empleados)
            {
                e.getDatosEmpleado();
            }
        }

        // Metodos particulares

        public void promedioSalario()
        {
            var consulta = from e in listaEmpleados
                           group e by e.EmpresaId into g
                           select new { empresa = g.Key, PromedioSalario = g.Average(e => e.Salario) };

            foreach (var resultado in consulta)
            {
                switch (resultado.empresa)
                {
                    case 1:
                        Console.WriteLine($"Empresa IAlpha - Promedio de salarios: {resultado.PromedioSalario}");
                        break;
                    case 2:
                        Console.WriteLine($"Empresa Udelar - Promedio de salarios: {resultado.PromedioSalario}");
                        break;
                    case 3:
                        Console.WriteLine($"Empresa SpaceZ - Promedio de salarios: {resultado.PromedioSalario}");
                        break;
                }
            }
        }

       
    }
}


