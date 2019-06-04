using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int lote = 0;

            for(int i = 0; i < 100; i++)
            {
                lote = lote + 10;
                Console.WriteLine("ticket impreso con enumeracion: " + lote);
            }
            Console.ReadKey(true);
        }
       
    }
}
