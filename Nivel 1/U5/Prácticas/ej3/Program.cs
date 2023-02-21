using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            int e, c = 0, ac = 0, p;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese edad: ");
                e = int.Parse(Console.ReadLine());

                if(e >= 18){
                    c++;
                    ac += e;
                }
            }

            p = ac / c;

            Console.WriteLine("El promedio de edad es: " + p);
        }
    }
}
