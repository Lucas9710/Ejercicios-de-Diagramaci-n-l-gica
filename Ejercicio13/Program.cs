using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int fecha1, fecha2, anio1, anio2, mes1, mes2, dia1, dia2;

            Console.WriteLine("ingrese la primera fecha en formato DDMMAAAA");
            fecha1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la segunda fecha en formato DDMMAAAA");
            fecha2 = int.Parse(Console.ReadLine());

            //logica del programa
            anio1 = fecha1 % 10000;
            anio2 = fecha2 % 10000;

            if(anio1 != anio2)
            {
                if(anio1 > anio2)
                {
                    Console.WriteLine("la segunda fecha es menor");
                }
                else
                {
                    Console.WriteLine("la primera fecha es menor");
                }
                          }
            else
            {
                mes1 = (fecha1 % 1000000) / 10000;
                mes2 = (fecha2 % 1000000) / 10000;

                if(mes1 != mes2)
                {
                    if(mes1 > mes2)
                    {
                        Console.WriteLine("la fecha 2 es menor");

                    }
                    else
                    {
                        Console.WriteLine("la fecha 1 es menor");
                    }
                }
                else
                {
                    dia1 = (fecha1 / 10000);
                    dia2 = (fecha2 / 10000);

                    if(dia1 != dia2)
                    {
                        if(dia1> dia2)
                        {
                            Console.WriteLine("fecha2 es menor");

                        }
                        else
                        {
                            Console.WriteLine("fecha1 es menor");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Las fechas son iguales");
                    }
                }
            }

            Console.ReadKey(true);
        
        }
    }
}
