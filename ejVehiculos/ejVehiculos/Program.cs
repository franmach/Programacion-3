using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> listaVehiculos=new List<Vehiculo>();

            Camion camion1 = new Camion(1, "Volvo", "FH16", 10, "Rojo", "2023", 20);
            listaVehiculos.Add(camion1);
            Camion camion2 = new Camion(2, "Mercedes-Benz", "Actros", 12, "Azul", "2022", 25);
            listaVehiculos.Add(camion2);
            Camion camion3 = new Camion(3, "MAN", "TGX", 8, "Blanco", "2024", 15);
            listaVehiculos.Add(camion3);

            Moto moto1 = new Moto(1, "Honda", "CBR600RR", 2, "Rojo", "2023", 600);
            listaVehiculos.Add(moto1);
            Moto moto2 = new Moto(2, "Yamaha", "YZF-R1", 2, "Azul", "2022", 1000);
            listaVehiculos.Add(moto2);
            Moto moto3 = new Moto(3, "Kawasaki", "Ninja ZX-6R", 2, "Verde", "2024", 636);
            listaVehiculos.Add(moto3);

            Auto auto1 = new Auto(1, "Toyota", "Corolla", 4, "Blanco", "2023", 5);
            listaVehiculos.Add(auto1);
            Auto auto2 = new Auto(2, "Ford", "Mustang", 4, "Negro", "2022", 4);
            listaVehiculos.Add(auto2);
            Auto auto3 = new Auto(3, "Chevrolet", "Camaro", 4, "Amarillo", "2024", 4);
            listaVehiculos.Add(auto3);

            void vehiculosXTipo(string tipo)
            {
                List<Vehiculo> vehiculosFiltrados = listaVehiculos.Where(v => v.GetType().Name.ToLower().Contains(tipo)).ToList();
                foreach (var v in vehiculosFiltrados)
                {
                    Console.WriteLine("Marca: " + v.marca + " ~Modelo: " + v.modelo);
                }
            }



            void cantVehiculosYxTipo()
            {
                int cantVehiculos = listaVehiculos.Count();
                int cantMotos = listaVehiculos.Where(v => v.GetType().Name.ToLower().Contains("moto")).Count();
                int cantAutos = listaVehiculos.Where(v => v.GetType().Name.ToLower().Contains("auto")).Count();
                int cantCamiones = listaVehiculos.Where(v => v.GetType().Name.ToLower().Contains("camion")).Count();

                Console.WriteLine("Cantidad vehiculos: " + cantVehiculos);
                Console.WriteLine("Cantidad motos: " + cantMotos);
                Console.WriteLine("Cantidad autos: " + cantAutos);
                Console.WriteLine("Cantidad camiones: " + cantCamiones);

            }


            Console.WriteLine("~~Autos~~");
            vehiculosXTipo("auto");
            Console.WriteLine("-------------------");
            Console.WriteLine("~~Motos~~");
            vehiculosXTipo("moto");


            //-------------------------

            cantVehiculosYxTipo();
        }


    }
}
