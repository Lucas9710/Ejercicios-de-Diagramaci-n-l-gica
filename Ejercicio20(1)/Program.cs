using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuestas_correctas, cant_preguntas, porcentajeDePreguntasCorrectas, nivel;

            Console.WriteLine("ingresar cantidad de preguntas respondidas");
            cant_preguntas = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresar cantidad de preguntas respondidas correctamente");
            respuestas_correctas = int.Parse(Console.ReadLine());

            porcentajeDePreguntasCorrectas = (respuestas_correctas * 100) / cant_preguntas;

            if(porcentajeDePreguntasCorrectas >= 89)
            {
                nivel = 1;

                Console.WriteLine("El porcentaje de preguntas correctas es: " + porcentajeDePreguntasCorrectas + " y conrresponde al nivel: " + nivel);
            }else if(porcentajeDePreguntasCorrectas >= 75 && porcentajeDePreguntasCorrectas < 89)
            {
                nivel = 2;
                Console.WriteLine("El porcentaje de preguntas correctas es: " + porcentajeDePreguntasCorrectas + " y conrresponde al nivel: " + nivel);
            }else if(porcentajeDePreguntasCorrectas >= 50 && porcentajeDePreguntasCorrectas < 70)
            {
                nivel = 3;
                Console.WriteLine("El porcentaje de preguntas correctas es: " + porcentajeDePreguntasCorrectas + " y conrresponde al nivel: " + nivel);

            }else if (porcentajeDePreguntasCorrectas > 50)
            {
                nivel = 4;
                Console.WriteLine("El porcentaje de preguntas correctas es: " + porcentajeDePreguntasCorrectas + " y conrresponde al nivel: " + nivel);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey(true);
        }
    }
}
