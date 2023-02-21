using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

            int n,c;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
            c = 0;
            
            for (int x = 1; x <= n ; x++)
            {
                if((n % x) == 0)
                    c++; 
            }

            if(c == 2)
                Console.WriteLine("Es un número primo");
            else
                Console.WriteLine("No es un número primo");

        }
    }
}
