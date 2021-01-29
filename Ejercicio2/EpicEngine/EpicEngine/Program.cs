using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> listarVehiculo = new List<Vehiculo>();
            Taller taller = new Taller();
            Camion miCamion = new Camion{ Placa = "SRJ987", MotorBueno = false };
            Lancha miLancha = new Lancha { Placa = "SMM256", MotorBueno = false };
            Automovil miAutomovil = new Automovil { Placa = "AJJ91B", MotorBueno = false };
            Moto miMoto = new Moto { Placa = "DKD98", MotorBueno = false };
            Console.WriteLine("Ingresando Vehiculo");
            Console.WriteLine(taller.ingresarVehiculo(miCamion));
            Console.WriteLine(taller.ingresarVehiculo(miLancha));
            Console.WriteLine(taller.ingresarVehiculo(miAutomovil));
            Console.WriteLine(taller.ingresarVehiculo(miMoto));
            Console.WriteLine("\n");
            Console.WriteLine("Reparando Motor\n");
            
            taller.repararVehiculi(miMoto);
            taller.repararVehiculi(miLancha);
            //taller.repararVehiculi();
            Console.WriteLine("Retirando Vehiculo\n");
            taller.retirarVehiculo(miMoto);
            taller.retirarVehiculo(miLancha);
            Console.WriteLine("\n");
            Console.WriteLine("Listando Vehiculos");
            listarVehiculo = taller.listarVehiculos();
            foreach(Vehiculo veh in listarVehiculo)
            {
                Console.WriteLine(veh.Placa);

            }

            Console.ReadKey();
        }
    }
}
