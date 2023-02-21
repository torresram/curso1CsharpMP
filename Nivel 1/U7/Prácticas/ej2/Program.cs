using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            int[] vNum = new int[10];
            int n, acum = 0,p, M = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                vNum[x] = n;
                acum += n;
            }
            
            p = acum / 10;

            for (int x = 0; x < 10; x++)
            {
                if(p < vNum[x]){
                    M = vNum[x];
                    Console.WriteLine("El número " + M + " es mayor al promedio.");
                }
            }
        }
    }
}
