using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.

            int N;

            Console.WriteLine("Ingrese un número: ");
            N = int.Parse(Console.ReadLine());

            if(N == 0)
                Console.WriteLine("Es cero");
            else if (N > 0)
                Console.WriteLine("Positivo");
            else
                Console.WriteLine("Negativo");

            
        }
    }
}
