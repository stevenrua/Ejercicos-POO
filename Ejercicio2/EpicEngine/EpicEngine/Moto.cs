using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicEngine
{
    class Moto : Vehiculo, IReparable
    {
        public string reparar()
        {
            MotorBueno = true;
            
            return "Moto Reparada";
        }
    }
}
