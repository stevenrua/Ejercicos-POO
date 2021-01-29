using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Models.Persona
{
    abstract class Espectador
    {
        public Espectador(string nombre)
        {
            Nombre = nombre;
        }
        public abstract double comprarBoleta(Obra obra);
        
        
        public string Nombre { get; set; }
    }
}
