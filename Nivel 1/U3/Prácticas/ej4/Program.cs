using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            int a,b,c,d,M;

            Console.WriteLine("Ingrese número 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 3: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 4: ");
            d = int.Parse(Console.ReadLine());

            if(a > b)
                M = a;
            else
                M = b;
            if(c > M)
                M = c;
            if(d > M)
                M = d;

            Console.WriteLine("El número menor es: " + M);

        }
    }
}
