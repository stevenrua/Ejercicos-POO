using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.ClasePadre
{
    abstract class Empleado {

        public abstract double calcularSalario();

        public string Nombre { get; set; }
    }
}
