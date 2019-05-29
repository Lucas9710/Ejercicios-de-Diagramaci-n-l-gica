using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5;

            Console.WriteLine("ingresar 5 numeros");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            num5 = int.Parse(Console.ReadLine());


            if (num2 > num1 && num3 > num1 && num4 > num1 && num5 > num1)
            {
                Console.WriteLine("el numero 1 es el menor");

            }
            else
            {
                if (num3 > num2 && num4 > num2 && num5 > num2)
                    {
                    Console.WriteLine("el numero 2 es el menor");
                }
                else
                {
                    if(num4 > num3 && num5 > num3)
                    {
                        Console.WriteLine("el numero 3 es el menor");
                    }
                    else
                    {
                        if (num5 > num4)
                        {
                            Console.WriteLine("el numero 4 es el menor"); ;
                        }
                        else
                        {
                            Console.WriteLine("el numero 5 es el menor");
                        }
                    }
                }
            }

            Console.ReadKey(true);
        }
    }
}
