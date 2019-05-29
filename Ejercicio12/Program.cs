using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Ejercicio12
    {
        static void Main(string[] args)
        {

            int num1, num2;

            Console.WriteLine("Ingresa los números");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num2 != 0)
            {
                Console.WriteLine($"El resultado es: {num1 / num2}");

            }
            else
            {
                Console.WriteLine("el divisor no puede ser el número 0");
            }

            Console.ReadKey(true);
        }
    }
}
