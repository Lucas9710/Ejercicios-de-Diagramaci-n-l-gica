using System;

namespace ejercicio5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int lados1, lado2;

            Console.WriteLine("Ingresar la base del triangulo");

            lados1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar el valor de los lados del triangulo");

            lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"La superficie del triangulo es:   {lados1 * lado2 / 2  }");

            Console.ReadKey(true);

        }
    }
}
