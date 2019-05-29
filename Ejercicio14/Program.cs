using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("ingresa el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresa el segundo numero");
            num2= int.Parse(Console.ReadLine());

            if(num1 > num2)
            {

            
                Console.WriteLine(num1);
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num2);
                Console.WriteLine(num1);
            }
            Console.ReadKey(true);

        }
    }
}
