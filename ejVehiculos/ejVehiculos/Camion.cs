using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejVehiculos
{
    internal class Camion:Vehiculo
    {
        public int toneladas;

        public Camion(int id, string marca, string modelo, int ruedas, string color, string ano, int toneladas) : base(id, marca, modelo, ruedas, color, ano)
        {
            this.toneladas = toneladas;
        }
    }
}
