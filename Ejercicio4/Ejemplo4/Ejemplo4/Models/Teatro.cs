using Ejemplo4.Models.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Models
{
    class Teatro
    {
        public Teatro(string nombre)
        {
            Nombre = nombre;
            numeroAsistentes = Constantes.CapacidadActual;
        }

        public bool venderBoleta(Obra obra, Espectador espectador)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Vendiendo Boletas");
            numeroAsistentes++;
            if (numeroAsistentes > Constantes.capacidad)
            {
                Console.WriteLine("No tenemos cupos");
                return Constantes.CuposNoDisponibles;
            }
            else
            {
                
                obra.espectadores.Add(espectador);
                obra.Recaudo += espectador.comprarBoleta(obra);
                Cupos = Constantes.capacidad - numeroAsistentes;
                
                return Constantes.CuposDisponibles;
                
            }
        }


        public string Nombre { get; set; }
        public int numeroAsistentes { get; set; }
        public int Cupos
        {
            get
            {
                return cuposRestantes;
            }

            set
            {
                cuposRestantes = value;
            }
        }
        private int cuposRestantes;

    }
}
