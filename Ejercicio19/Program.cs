using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;

            Console.WriteLine("Ingresa el dia");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el mes");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el año");
            año = int.Parse(Console.ReadLine());


            if (dia > 31 || dia < 0)
            {
                Console.WriteLine("el día es inválido");

                if (mes > 12 || mes < 0)
                {
                    Console.WriteLine("El mes es inválido");

                    if(año < 0)
                    {
                        Console.WriteLine("El año es inválido");
                    }
                    else
                    {
                        Console.WriteLine("El año es valido");
                    }
                }
                else
                {
                    if(año < 0)
                    {
                        Console.WriteLine("El año es inválido");
                    }
                    
                }
            }
            else
            {
                if(mes > 12 || mes < 0)
                {
                    Console.WriteLine("el mes es inválido");

                    if (año < 0)
                    {
                        Console.WriteLine("El año es inválido");
                    }
                    

                }
                else
                {
                    if (año < 0)
                    {
                        Console.WriteLine("El año es inválido");
                    }
                    else
                    {
                        Console.WriteLine("La fecha es valida");
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}
