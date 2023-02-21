using System;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

            float a,b,c,p;
            
            Console.WriteLine("Nota 1: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota 3: ");
            c = float.Parse(Console.ReadLine());

            p = (a + b + c) / 3;

            Console.WriteLine("El promedio del alumno es: " + p.ToString("0.00"));

        }
    }
}
