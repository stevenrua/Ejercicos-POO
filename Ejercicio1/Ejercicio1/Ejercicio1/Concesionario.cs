using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Concesionario
    {
        public Concesionario(string nombre, int capacidadTotal)
        {
            this.nombre = nombre;
            this.capacidadTotal = capacidadTotal;
            this.capacidadActual = capacidadTotal;
        }

        public bool ingresarCarro(Carro carro)
        {
            bool puedeIngresar = true;
            if (listaCarros.Count() == 0)
            {
                listaCarros.Add(carro);
                capacidadActual--;
                Console.WriteLine("perro hp");
                return puedeIngresar;
            }
            else
            {
                if (listaCarros.Count(e => e.getPlaca() == carro.getPlaca())!=0)
                {
                    puedeIngresar = false;
                    
                }
                else if(capacidadActual>0)
                {
                    listaCarros.Add(carro);
                    capacidadActual--;
                }               
                
            }
            if (capacidadActual == 0)
            {
                Console.WriteLine("No puede ingresar más carros");
            }
            return puedeIngresar;
        }
        public Carro buscarCarroPlaca(string placaCarro)
        {
            listaCarroPlaca = listaCarros.Find(e => e.getPlaca() == placaCarro);
            if (listaCarroPlaca == null )
            {
                Console.WriteLine("No tenemos ese carro con esa placa");
            }
            return listaCarroPlaca;
        }
        public List<Carro> buscarCarroModelo(string modeloCarro)
        {
            listaCarrosMarca = listaCarros.FindAll(e => e.getModelo() == modeloCarro);
            if (listaCarrosMarca.Count == 0)
            {
                Console.WriteLine("No tenemos esa marca de carro");
            }

            return listaCarrosMarca;
        }
        public List<Carro> buscarSoloNuevos(bool esNuevo)
        {
            listaCarroNuevo = listaCarros.FindAll(e => e.getesNuevo() == esNuevo);
            if (listaCarroNuevo.Count() == 0)
            {
                Console.WriteLine("No tenemos carros nuevos");
            }
            return listaCarroNuevo;
        }
        public List<Carro> buscarPorPrecio(int precio)
        {
            listaCarroPrecio = listaCarros.FindAll(e => e.getPrecio() <= precio);
            if (listaCarroPrecio.Count() == 0)
            {
                Console.WriteLine("No tenemos carros menores a ese precio");
            }
            return listaCarroPrecio;
        }
        public void venderCarro(Carro carr)
        {
            int indi;
            indi=listaCarros.IndexOf(carr);
            listaCarros.RemoveAt(indi);
            capacidadActual++;
            
        }
        public int getCapacidadTotal()
        {
            return capacidadTotal;
        }
       
        public int getCapacidadActual()
        {
            
            return capacidadActual;
        }

        

        private string nombre;
        private int capacidadTotal;
        private int capacidadActual;
        private Carro listaCarroPlaca;
        private List<Carro> listaCarros = new List<Carro>();
        private List<Carro> listaCarrosMarca = new List<Carro>();
        private List<Carro> listaCarroNuevo = new List<Carro>();
        private List<Carro> listaCarroPrecio = new List<Carro>();
    }
}
