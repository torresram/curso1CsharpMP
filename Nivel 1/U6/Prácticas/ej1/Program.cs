using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            int n, con, primos;
            con = 0;
            primos = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                con = 0;
                for (int y = 1; y <= n; y++)
                {
                    if (n % y == 0)
                        con++;
                }

                if (con == 2)
                    primos++;
            }

            Console.WriteLine("La cantidad de números primos ingresados es: " + primos);
        }
    }
}
