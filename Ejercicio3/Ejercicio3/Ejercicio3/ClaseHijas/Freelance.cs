using Ejercicio3.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.ClaseHijas
{
    class Freelance : Empleado
    {
        public Freelance(string nombre, long valorHora, double numeroHoras)
        {
            Nombre = nombre;
            this.valorHora = valorHora;
            this.numeroHoras = numeroHoras;
        }
        public override double calcularSalario() => numeroHoras = numeroHoras * valorHora;
        

        

        public long valorHora { get; set; }
        public double numeroHoras{ get; set; }
    }
}
