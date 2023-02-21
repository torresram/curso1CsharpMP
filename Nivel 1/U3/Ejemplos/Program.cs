using System;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
          int edad = 20;
/*   
            if(edad > 21){
                if(edad > 30)
                   Console.WriteLine("30% de descuento");
                else
                   Console.WriteLine("21% de descuento");
            }else
                Console.WriteLine("10% de descuento"); */

            if (edad > 30)
                Console.WriteLine("30% OFF");
            else if(edad > 20)
                Console.WriteLine("21 OFF");
            else if(edad == 18)
                Console.WriteLine("10 OFF");
            else
                Console.WriteLine("5% OFF");
            }
        }
    }

