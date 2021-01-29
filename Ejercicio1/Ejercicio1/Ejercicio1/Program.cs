using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> marcaCarro = new List<Carro>();
            List<Carro> nuevo = new List<Carro>();
            List<Carro> precio = new List<Carro>();
            Concesionario conse = new Concesionario("Parqueadero Steven", 10);
            Carro miCarro = new Carro("AJJ91Q", "mazda", "2006", 23000000, true);
            Carro miCarro2 = new Carro("AJJ91", "mazda", "2006", 23000000, false);
            Carro miCarro3 = new Carro("AJJ91Qes", "Hyundai", "2006", 276000000, true);
            Carro miCarro4 = new Carro("DKD98", "YAMAHA", "1993", 2000000, false);
            Console.WriteLine(conse.ingresarCarro(miCarro));
            Console.WriteLine(conse.ingresarCarro(miCarro2));
            Console.WriteLine(conse.ingresarCarro(miCarro3));
            Console.WriteLine(conse.ingresarCarro(miCarro4));

            Console.WriteLine("Busqueda de carro por placa");
            Carro placaCarro = conse.buscarCarroPlaca("DKD98sd");
            Console.WriteLine("\n");
            if (placaCarro != null)
            {
                Console.WriteLine(placaCarro.getPlaca());
                Console.WriteLine(placaCarro.getMarca());
                Console.WriteLine(placaCarro.getModelo());
                Console.WriteLine(placaCarro.getPrecio());
                Console.WriteLine(placaCarro.getesNuevo());
                Console.WriteLine("\n");
            }
            Console.WriteLine("Busqueda por Marca\n");
            marcaCarro = conse.buscarCarroModelo("Hyundai");
            foreach (Carro car in marcaCarro)
            {
                Console.WriteLine(car.getPlaca());
                Console.WriteLine(car.getMarca());
                Console.WriteLine(car.getModelo());
                Console.WriteLine(car.getPrecio());
                Console.WriteLine(car.getesNuevo());
                Console.WriteLine("\n");
            }
            Console.WriteLine("Busqueda si es nuevo\n");
            nuevo = conse.buscarSoloNuevos(true);
            foreach (Carro car in nuevo)
            {
                Console.WriteLine(car.getPlaca());
                Console.WriteLine(car.getMarca());
                Console.WriteLine(car.getModelo());
                Console.WriteLine(car.getPrecio());
                Console.WriteLine(car.getesNuevo());
                Console.WriteLine("\n");
            }

            Console.WriteLine("Busqueda de carro por precio\n");
            precio = conse.buscarPorPrecio(30000000);
            foreach (Carro car in precio)
            {
                Console.WriteLine(car.getPlaca());
                Console.WriteLine(car.getMarca());
                Console.WriteLine(car.getModelo());
                Console.WriteLine(car.getPrecio());
                Console.WriteLine(car.getesNuevo());
                Console.WriteLine("\n");
            }

            conse.venderCarro(miCarro3);

            Console.WriteLine("Busqueda por Marca\n");
            marcaCarro = conse.buscarCarroModelo("Hyundai");
            foreach (Carro car in marcaCarro)
            {
                Console.WriteLine(car.getPlaca());
                Console.WriteLine(car.getMarca());
                Console.WriteLine(car.getModelo());
                Console.WriteLine(car.getPrecio());
                Console.WriteLine(car.getesNuevo());
                Console.WriteLine("\n");
            }
            Console.WriteLine(conse.getCapacidadActual());

            Console.ReadKey();
        }
    }
}
