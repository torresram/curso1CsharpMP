using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int[] vNum = new int[10];
            int n, max, pos = 0, D;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                vNum[x] = n;                
            }

            max = vNum[0];

            for (int x = 0; x < 10; x++)
            {
                D = vNum[x];

                if(D > max){
                    max = D;
                    pos = x + 1;
                }
            }

            Console.WriteLine("El mayor número ingresado es " + max + " en la posición " + pos);
        }
    }
}
