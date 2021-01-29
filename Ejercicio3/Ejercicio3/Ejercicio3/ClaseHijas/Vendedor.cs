using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.ClaseHijas
{
    class Vendedor:Directo
    {
        public Vendedor(string nombre,double salario, double ventasDelMes):base(nombre,salario)
        {

            Salario = salario;
            Nombre = nombre;            
            this.ventasDelMes = ventasDelMes;
        }
        public double calcularComision()
        {
            if (Salario < 1000000)
            {
                comision = (3 * ventasDelMes) / 100;
            }
            else
            {
                comision = (2.6 * ventasDelMes) / 100;
            }
            return comision;
        }

        public override double calcularSalario()
        {
            aporteSalud = calcularSalud();
            aportePension = calcularPension();
            comision = calcularComision();
            return (Salario = Salario - aportePension - aporteSalud + comision);
        }


        public double ventasDelMes { get; set; }
        private double aporteSalud;
        private double aportePension;
        private double comision;
    }
}
