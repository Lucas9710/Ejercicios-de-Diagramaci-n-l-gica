using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("ingresa los 3 numero");
            num1 = int.Parse(Console.ReadLine());
           num2 = int.Parse(Console.ReadLine());
           num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("el numero 3 es el menor");
                }
                else
                {
                    Console.WriteLine("el numero 2 es el menor");
                }
            }
            else
            {
                if (num3 > num1)
                {
                    Console.WriteLine("el numero 1 es el menor");
                }
                else
                {
                   Console.WriteLine("el numero 3 es el menor");
                }
                Console.ReadKey(true);
            }
    }
}
}