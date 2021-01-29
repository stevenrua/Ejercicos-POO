using Ejemplo4.Models;
using Ejemplo4.Models.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Obra obra1 = new Obra("Romeo Y Julieta", 10);
            Abonado esp1 = new Abonado("Steven Rúa");
            Abonado esp2 = new Abonado("Shara Montoya");
            Abonado esp3 = new Abonado("Celeste Rúa");
            Ocasional esp4 = new Ocasional("Fabiola Jaramillo");
            Ocasional esp5 = new Ocasional("Gustavo Rúa");
            Ocasional esp6 = new Ocasional("Lucia Jaramillo");
            Ocasional esp7 = new Ocasional("Johny Rúa");

            Teatro t = new Teatro("Teatro Junin");
            Console.WriteLine(t.venderBoleta(obra1, esp1));
            Console.WriteLine(t.venderBoleta(obra1, esp2));
            Console.WriteLine(t.venderBoleta(obra1, esp3));
            Console.WriteLine(t.venderBoleta(obra1, esp4));
            Console.WriteLine(t.venderBoleta(obra1, esp5));
            Console.WriteLine(t.venderBoleta(obra1, esp6));
            Console.WriteLine(t.venderBoleta(obra1, esp7));
            Console.WriteLine(t.Cupos);

            obra1.mostrarAbonados();
            obra1.mostrarOcasionales();

            Console.ReadKey();
        }
    }
}
