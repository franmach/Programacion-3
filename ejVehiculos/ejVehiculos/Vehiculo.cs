using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejVehiculos
{
    internal class Vehiculo
    {
        public int id {  get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int ruedas {  get; set; }
        public string color { get; set; }
        public string ano {  get; set; }

        public Vehiculo(int id, string marca, string modelo, int ruedas, string color, string ano)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.ruedas = ruedas;
            this.color = color;
            this.ano = ano;
        }

       
    }
}
