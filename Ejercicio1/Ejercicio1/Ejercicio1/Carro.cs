using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Carro
    {
        public Carro(string placa, string marca, string modelo, int precio, bool esNuevo)
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.esNuevo = esNuevo;
        }

        public string getPlaca()
        {
            return placa;
        }
        public string getMarca()
        {
            return marca;
        }
        public string getModelo()
        {
            return modelo;
        }
        public int getPrecio()
        {
            return precio;
        }
        public bool getesNuevo()
        {
            return esNuevo;
        }

        private string placa;
        private string marca;
        private string modelo;
        private int precio;
        private bool esNuevo;
    }
}
