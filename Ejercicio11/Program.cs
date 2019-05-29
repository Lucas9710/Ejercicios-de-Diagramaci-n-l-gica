using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Ejercicio11
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4, promedio;
             const int aprobado = 6;


            Console.WriteLine("Ingresar la nota 1");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nota 2");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nota 3");
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nota 4");
            nota4 = int.Parse(Console.ReadLine());


            //logica del programa

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            if (promedio < aprobado)
            {
                Console.WriteLine("Esta desaprobado");
            }
            else
            {
                Console.WriteLine("Esta aprobado");

            }
               

            



            Console.ReadKey(true);
        }
    }
}
