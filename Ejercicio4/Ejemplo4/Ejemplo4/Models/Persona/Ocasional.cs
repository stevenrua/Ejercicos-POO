using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Models.Persona
{
    class Ocasional : Espectador
    {
        public Ocasional(string nombre):base(nombre) { }
        public override double comprarBoleta(Obra obra)
        {
            double precioBoleta = Constantes.precioOcasional;
            if (obra.Hora>9)
            {
                precioBoleta = precioBoleta + (precioBoleta * 15) / 100;

            }
            return precioBoleta;
        }

       
    }
}
