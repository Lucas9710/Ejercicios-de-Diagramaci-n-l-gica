using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ejercicio1
    {
        static void Main(string[] args)

        {

            int num_1, num_2, num_3, num4;

            Console.WriteLine("ingresar 4 números");

            num_1 = int.Parse(Console.ReadLine());
            num_2 = int.Parse(Console.ReadLine());
            num_3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"el resultado es : {num_1 + num_2 + num_3 + num4}");

            Console.ReadKey(true);
        }
    }
}
