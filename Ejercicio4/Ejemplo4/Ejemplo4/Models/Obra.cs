using Ejemplo4.Models.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Models
{
    class Obra
    {
        public Obra(string titulo, int hora)
        {
            
            this.titulo = titulo;
            Hora = hora;
        }

        public void mostrarAbonados()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Mostrando Espectadores Abonados\n");
            listaAbonados = espectadores.FindAll(e => e.GetType().ToString() == "Ejemplo4.Models.Persona.Abonado");
            foreach (Abonado abo in listaAbonados)
            {
                Console.WriteLine(abo.Nombre);
            }
        }
        public void mostrarOcasionales()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Mostrando Espectadores Ocasionales\n");
            listaOcasionales = espectadores.FindAll(e => e.GetType().ToString() == "Ejemplo4.Models.Persona.Ocasional");
            foreach (Ocasional abo in listaOcasionales)
            {
                Console.WriteLine(abo.Nombre);
            }
        }
        private string titulo;
        private double recaudo;
        private List<Espectador> listaAbonados = new List<Espectador>();
        private List<Espectador> listaOcasionales = new List<Espectador>();
        public List<Espectador> espectadores { get; set; } = new List<Espectador>();
        public int Hora { get; set; }
        public double Recaudo
        {
            get
            {
                return recaudo;
            }
            set
            {
                recaudo = value;
            }
        }
    }
}
