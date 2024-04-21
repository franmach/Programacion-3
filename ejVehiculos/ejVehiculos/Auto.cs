using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejVehiculos
{
    internal class Auto:Vehiculo
    {
        public int cantPasajeros {  get; set; }
        public Auto(int id, string marca, string modelo, int ruedas, string color, string ano, int cantPasajeros) : base(id, marca, modelo, ruedas, color, ano)
        {
            this.cantPasajeros = cantPasajeros;
        }
    }
}
