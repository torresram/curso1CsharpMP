using System;

namespace TPFinal_Torres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
            //
            //a. El mayor de los números pares.
            //b. La cantidad de números impares.
            //c. El menor de los números primos.
            //
            //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
            
            int n, conImp = 0, maxPar = 0, menPrimo = 0;
            bool banPar = false;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            while(n != 0)
            {
                if(n % 2 == 0)
                {
                    if(banPar == false)
                    {
                        maxPar = n;
                        banPar = true;
                    }else if(n > maxPar)
                        maxPar = n;
                }else
                    conImp++;

                menPrimo = n;

                if(primo(ref n))
                    if(n < menPrimo)
                        menPrimo = n;
                        
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());            
            }

            Console.WriteLine("El mayor de los números pares es " + maxPar);
            Console.WriteLine("La cantidad de números impares es " + conImp);
            Console.WriteLine("El menor de los números primos es " + menPrimo);
        }

        static bool primo(ref int a)
        {
            int cont = 0, x = 0;

            while(x <= a)
            {   
                x++;

                if(a % x == 0)
                    cont++;
            }

            if(cont == 2)
                return true;
            else
                return false;
        }
    }
}
// 12.24.28.2.4.88 - pares, mayor 88 
// 15.13.11.7.9.47 - 6 impares
// 71.139.193.13.37.7 - primos, menor 7