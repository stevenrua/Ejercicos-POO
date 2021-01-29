using Ejercicio3.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.ClaseHijas
{
    class Directo : Empleado
    {
        public Directo(string nombre, double salario)
        {
            Nombre = nombre;
            Salario = salario;
        }
        public  double calcularSalud() => aporteSalud = (4 * Salario / 100);

        public double calcularPension() => aportePension = (5 * Salario / 100);


        public override double calcularSalario()
        {
            aporteSalud = calcularSalud();
            aportePension = calcularPension();
            return (Salario = Salario - aportePension - aporteSalud);
        }    
        

        public double Salario { get; set; }
        private double aporteSalud;
        private double aportePension;
    }
}
