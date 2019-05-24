using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            float lados;

            Console.WriteLine("ingresar el lado del cuadrado");

            lados = int.Parse(Console.ReadLine());

            Console.WriteLine($"la superficie es.  {lados * 4 }");

            Console.ReadKey(true);
        }
    }
}
