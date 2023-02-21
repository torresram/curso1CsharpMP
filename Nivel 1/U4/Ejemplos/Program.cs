using System;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND OR NOT

            int edad = 20;
            char inicial = 'J';

            if((inicial == 'J' || edad > 20) && inicial == 'H')
                Console.WriteLine("Descuento de 20%"); 
        }
    }
}
