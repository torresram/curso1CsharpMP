using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //paso 0: declarar variables
            int n1,n2, res;

            //paso 1: pedir valores
            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine()); //asigna el valor

            Console.WriteLine("Ingrese otro número: ");
            n2 = int.Parse(Console.ReadLine());

            //paso 2: realizar calculos
            res = n1 + n2;

            //paso 3: emitir resultado
            Console.WriteLine("El resultado es: " + res);
            Console.WriteLine("Gracias por usar esta calculadora poronga");
            
        }
    }
}
