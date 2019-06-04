using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 0, numero = 0;

            do
            {
                Console.WriteLine("ingrese un numero igual o mayor a 0");
                numero = int.Parse(Console.ReadLine());
            } while (numero < 0);

            if (numero > 0) {

                do
                {
                    factorial = factorial * numero;
                    numero = numero - 1;

                    Console.WriteLine("El factorial de su numero es igual a: " + factorial);
                } while (numero => 1);
            }else 
            {
                
                factorial = 1;
                Console.WriteLine("El factorial de su numero es igual a: " + factorial);
            }
            Console.ReadKey(true)
;        }
    }
}
