using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9

{
    class Ejercicio9
    {
        static void Main(string[] args)
        {
            int parcial_integrador, parcial, trabajo_practico, nota_final;

            Console.WriteLine("Ingrese la nota del parcial");
            parcial = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del trabajo practico");
            trabajo_practico = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del parcial integrador");
            parcial_integrador = int.Parse(Console.ReadLine());

            //Lógica del programa

            parcial = (30 * parcial) / 100;
            trabajo_practico = (20 * trabajo_practico) / 100;
            parcial_integrador = (50 * parcial_integrador) / 100;
            nota_final = parcial + trabajo_practico + parcial_integrador;

            Console.WriteLine("la nota final es: " + nota_final);

            Console.ReadKey(true);


        }
    }
}
