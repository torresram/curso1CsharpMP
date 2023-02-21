using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

            int n, conPri = 0, acPri = 0;
            float promedio;
            bool p;

            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());

            while(n != 0)
            {
                p = primo(n);

                if(p == true)
                {
                    conPri++;
                    acPri += n;
                }

                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }

            promedio = acPri / conPri;

            Console.WriteLine("El promedio de verga es " + promedio);
        }

        static bool primo(int a)
        {
            int con = 0, x = 0;

            while(x <= a)
            {
                x++;
                
                if(a % x == 0)
                    con++;
            }

            if(con == 2)
                return true;
            else    
                return false;
        }
    }
}
