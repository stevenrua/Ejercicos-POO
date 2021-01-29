using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicEngine
{
    class Taller
    {

        public bool ingresarVehiculo(Vehiculo vehi)
        {
            bool puedeIngresar = false;
            if (!vehi.MotorBueno)
            {
                listaVehiculos.Add(vehi);
                puedeIngresar = true;
            }
            return puedeIngresar;
        }
        public void repararVehiculi(IReparable reparVehi)
        {
            

            Console.WriteLine(reparVehi.reparar());
            
        }
        public bool retirarVehiculo(Vehiculo retirarVehi)
        {
            int index;
            bool puedeSalir = false;
            retirar = listaVehiculos.Find(e => e.Placa == retirarVehi.Placa);
            if (retirar == null)
            {
                Console.WriteLine("No tenemos ese Vehiculo en nuestro taller");
                
            }else if (retirarVehi.MotorBueno && retirar!=null)
            {
                index = listaVehiculos.IndexOf(retirarVehi);
                listaVehiculos.RemoveAt(index);
                Console.WriteLine("Vehiculo con placas :" + retirarVehi.Placa + " Ha salido");
                puedeSalir = true;
            }else if (!retirarVehi.MotorBueno && retirar!=null)
            {
                Console.WriteLine("El vehiculo aún no esta reparado");
                Console.WriteLine(retirarVehi.MotorBueno);
            }
            
            return puedeSalir;
        }
        public List<Vehiculo> listarVehiculos()
        {
            if (listaVehiculos.Count() == 0)
            {
                Console.WriteLine("Taller vacio");
            }
            
            return listaVehiculos;
        }


        private List<Vehiculo> listaVehiculos= new List<Vehiculo>();
        private Vehiculo retirar;
    }
}
