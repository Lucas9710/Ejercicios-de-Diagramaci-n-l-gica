using System;

namespace ejercicio6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, num6;

            Console.WriteLine("Ingresa los 6 numeros");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            num5 = int.Parse(Console.ReadLine());
           num6 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El promedio es: {num1 + num2 + num3 + num4 + num5 + num6 / 6}");

            Console.ReadKey(true);

        }
    }
}
