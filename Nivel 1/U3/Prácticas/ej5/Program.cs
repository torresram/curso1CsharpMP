using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

            int a,b,c,d;           

            Console.WriteLine("Ingrese número 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 3: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 4: ");
            d = int.Parse(Console.ReadLine());

            if(a > 100)
                Console.WriteLine("El primer número " + a + " es mayor a 100.");
            if(b > 100)
                Console.WriteLine("El segundo número " + b + " es mayor a 100.");
            if(c > 100)
                Console.WriteLine("El tercer número " + c + " es mayor a 100.");
            if(d > 100)
                Console.WriteLine("El cuarto número " + d + " es mayor a 100.");
        }
    }
}
