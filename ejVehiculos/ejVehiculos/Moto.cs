using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejVehiculos
{
    internal class Moto:Vehiculo
    {
        public int cilindradas;

        public Moto(int id, string marca, string modelo, int ruedas, string color, string ano, int cilindradas):base(id, marca, modelo, ruedas, color, ano)
        {
            this.cilindradas = cilindradas;
        }
    }
}
