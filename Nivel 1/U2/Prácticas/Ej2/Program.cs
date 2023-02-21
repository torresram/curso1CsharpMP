using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo
            
            int n,cubo;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            cubo = n * n * n;

            Console.WriteLine("El número al cubo es: " + cubo);

        }
    }
}
