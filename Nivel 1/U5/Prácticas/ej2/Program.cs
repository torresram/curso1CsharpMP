using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            int n,M;

            M = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                if(n > M)
                    M = n;
            }

            Console.WriteLine("El mayor número ingresado es " + M);

        }
    }
}
