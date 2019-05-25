using System;

namespace ejercicio8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fecha, anio, mes, dia;

            Console.WriteLine("Ingrese la fecha");
            fecha = int.Parse(Console.ReadLine());

            dia = fecha / 1000000;
            mes = (fecha % 1000000) / 10000;
            anio = fecha % 10000;

            Console.WriteLine("la fecha es: " + dia + " " + " " + mes + " " + anio);

            Console.ReadKey(true);


            




        }
    }
}
