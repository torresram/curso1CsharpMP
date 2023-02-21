using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int n1, con = 0;
           

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n1 = int.Parse(Console.ReadLine());

                if(par(n1))
                    con++;
            }

            Console.WriteLine("La cantidad de números pares ingresados es " + con);

        }

        static bool par(int a)
        {                       
            if(a % 2 == 0)
                return true;                          
            else
                return false;       
        }
    }
}
