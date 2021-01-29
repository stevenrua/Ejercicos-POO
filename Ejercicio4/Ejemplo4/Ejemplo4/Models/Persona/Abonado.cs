using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Models.Persona
{
    class Abonado : Espectador
    {
        public Abonado(string nombre) : base(nombre) { }
        
        public override double comprarBoleta(Obra obra)
        {
            double valorBoleta = Constantes.precioAbonado;
            if (obra.Hora > 9)
            {
                valorBoleta = valorBoleta + (valorBoleta * 15)/100;
            }

            return valorBoleta;
        }
    }
}
