using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
          //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int a,b,c;

            Console.WriteLine("Ingrese número 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 3: ");
            c = int.Parse(Console.ReadLine());

            if((a + b) > (b * c))
                Console.WriteLine("Se cumple la consigna");
            else
                Console.WriteLine("No se cumple la consigna");        
        }
    }
}
