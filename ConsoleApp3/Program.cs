using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos , minutos, horas;

            //pido datos e inicializo las variables

            Console.WriteLine("ingresa la hora");
            horas = int.Parse(Console.ReadLine());
           
            

            //lógica del programa

            if(horas <= 24){
                horas = horas * 3600;

                Console.WriteLine("ingresa los minutos");
                minutos = int.Parse(Console.ReadLine());
                if (minutos <= 60)
                {
                    
                   
                    minutos = minutos * 60;

                    Console.WriteLine("ingresa los segundos");
                    segundos = int.Parse(Console.ReadLine());

                    Console.WriteLine("el resultado es: " + (horas + segundos + minutos));
                }
                else
                {
                    Console.WriteLine("ingrese bien los minutos");
                }


            }
            else
            {
                Console.WriteLine("ingrese bien la hora");
            }
           

            


            Console.ReadKey(true);
        }
    }
}
