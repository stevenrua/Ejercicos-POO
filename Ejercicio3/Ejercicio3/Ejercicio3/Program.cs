using Ejercicio3.ClaseHijas;
using Ejercicio3.CalNomina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hdhdhdhd");
            //Directo di = new Directo("Rúa", 123456789);
            //Vendedor vend = new Vendedor("Steven", 1000000, 124949494);
            //Freelance fre = new Freelance("Shara", 120, 2);

            //Console.WriteLine(di.Nombre);
            //Console.WriteLine(vend.Nombre);
            //Console.WriteLine(fre.Nombre);

            //Console.WriteLine(di.calcularPension());
            //Console.WriteLine(di.calcularSalario());

            //Console.WriteLine(vend.calcularComision());
            //Console.WriteLine(vend.calcularSalario());
            //Console.WriteLine(fre.calcularSalario());

            //if (vend.GetType().ToString() == "Ejercicio3.ClaseHijas.Vendedor")
            //{
            //    Console.WriteLine("sos perra dsdsd");
            //}

            Nomina nom = new Nomina();
            nom.calcularNomina();
            nom.listarDirectos();
            nom.listarFreelance();
            nom.mostrarComisiones();


            Console.ReadKey();
        }
    }
}
