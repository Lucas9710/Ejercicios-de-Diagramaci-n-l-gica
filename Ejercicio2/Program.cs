using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, superficie;

            Console.WriteLine("Ingresar los lados del rectangulo ");

            lado1 = int.Parse(Console.ReadLine());
            lado2 = int.Parse(Console.ReadLine());
            superficie = lado1 * lado2;

            Console.WriteLine("la superficie es: " + superficie);

             Console.ReadKey(true);
        }
    }
}
