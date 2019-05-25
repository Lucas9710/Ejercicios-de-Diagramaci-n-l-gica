using System;

namespace Ejercicio7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int total, parcial;

            Console.WriteLine("Ingresar el numero total");

            total = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar el numero parcial");
            parcial = int.Parse(Console.ReadLine());

            Console.WriteLine($"el porcentaje que representa el numero parcial al numero total es: {parcial * 100 / total }");

            Console.ReadKey(true);

        }
    }
}
