using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 1;
            for (int i=1; i <=10; i++) {             
                resultado = resultado * 2;
                Console.WriteLine("2 elevado a la: " + i + " es igual a " + resultado);
            }
            Console.ReadKey(true);
        }
    }
}
