using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
            int N;
            
            Console.WriteLine("Ingrese un número");
            N = int.Parse(Console.ReadLine());

            if(N > 10)
                Console.WriteLine("Es mayor a 10");
            else
                Console.WriteLine("Es menor a 10");
        }
    }
}
