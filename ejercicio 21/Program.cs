using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int año = 0;
            Boolean bisiesto;

            Console.WriteLine("ingresar año");
            año = int.Parse(Console.ReadLine());

            if (año%400 == 0 || (año %4 == 0 && año %100 != 0)) {
                bisiesto = true;
            }
            else
            {
                bisiesto = false;
            }

            if(bisiesto == true)
            {
                if(año > 2019)
                {
                    Console.WriteLine("el año sera bisiesto");
                }else if(año == 2019)
                {
                    Console.WriteLine("el año es bisiesto");
                }else if(año < 2019)
                {
                    Console.WriteLine("el año fue bisiesto");
                }
            }else if(bisiesto == false)
            {
                Console.WriteLine("El año no es bisiesto");
            }
            Console.ReadKey(true);
        }
    }
}
