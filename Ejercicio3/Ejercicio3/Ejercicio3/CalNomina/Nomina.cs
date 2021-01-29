using Ejercicio3.ClaseHijas;
using Ejercicio3.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.CalNomina
{
    class Nomina
    {
        public Nomina()
        {
            listaEmpleados.Add(new Directo("Juan",2100000));
            listaEmpleados.Add(new Directo("Dario", 3400000));
            listaEmpleados.Add(new Vendedor("Pedro", 1000000, 27500000));
            listaEmpleados.Add(new Vendedor("Maria", 956000, 20000000));
            listaEmpleados.Add(new Freelance("Catalina", 23000, 148));
            listaEmpleados.Add(new Freelance("Carlos", 31000, 80));
        }

        public void calcularNomina()
        {
            Console.WriteLine("Calculando Salario de los Empleados\n");
            foreach (Empleado emp in listaEmpleados)
            {
                Console.WriteLine("El sueldo de {0} es: {1} ",emp.Nombre,  emp.calcularSalario());
            }
            Console.WriteLine("\n");
        }
        public void listarDirectos()
        {
            Console.WriteLine("Listando Empleados Directos\n");
            listarDirecto = listaEmpleados.FindAll(e => e.GetType().ToString() == "Ejercicio3.ClaseHijas.Directo" 
                                                  || e.GetType().ToString() == "Ejercicio3.ClaseHijas.Vendedor");
            
            foreach (Empleado lis in listarDirecto)
            {
                Console.WriteLine(lis.Nombre);
            }
            Console.WriteLine("\n");
        }

        public void listarFreelance()
        {
            Console.WriteLine("Listando Empleados Freelance\n");
            listarFreelances = listaEmpleados.FindAll(e => e.GetType().ToString() == "Ejercicio3.ClaseHijas.Freelance");
                                                  

            foreach (Empleado lis in listarFreelances)
            {
                Console.WriteLine(lis.Nombre);
            }
            Console.WriteLine("\n");
        }

        public void mostrarComisiones()
        {
            Console.WriteLine("Mostrando comisiones de los empleados\n");
            foreach (Empleado emp in listaEmpleados)
            {
                listarVendedor = listaEmpleados.FindAll(e=>e.GetType().ToString()=="Ejercicio3.ClaseHijas.Vendedor");
            }
            foreach (Vendedor vend in listarVendedor)
            {
                Console.WriteLine("La comisión del vendedor {0} es: {1} ",vend.Nombre, vend.calcularComision());
            }
        }


        private List<Empleado> listaEmpleados = new List<Empleado>();
        private List<Empleado> listarDirecto = new List<Empleado>();
        private List<Empleado> listarFreelances = new List<Empleado>();
        private List<Empleado> listarVendedor = new List<Empleado>();
    }
}
