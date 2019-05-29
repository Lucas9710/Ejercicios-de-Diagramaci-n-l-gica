using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int sueldo_basico, antiguedad;

            Console.WriteLine("ingrese el nombre del empleado, su sueldo básico y su antiguedad");

            nombre = Console.ReadLine();
            sueldo_basico = int.Parse(Console.ReadLine());
            antiguedad = int.Parse(Console.ReadLine());

            if (antiguedad > 9)
            {
                int sueldo = (sueldo_basico * 40) / 100 + sueldo_basico;
                Console.WriteLine("el sueldo de " + nombre + " es " + sueldo);
            }
            else
            {
                Console.WriteLine("el sueldo de " + nombre + " es " + sueldo_basico);
            }
            Console.ReadKey(true);
        }
    }
}
