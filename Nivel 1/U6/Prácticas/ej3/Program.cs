using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            //El fin de la carga se notifica con un número negativo. 
            //Luego mostrar cuántos números tiene cada lista

            int n, lista = 0, conNum = 0;
            
            Console.WriteLine("Ingrese número: ");
            n = int.Parse(Console.ReadLine());

            while(n >= 0)
            {
                lista++;
                conNum = 0;
                while (n > 0)
                {
                    conNum++;

                    Console.WriteLine("Ingrese número: ");
                    n = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("La lista " + lista + " tiene " + conNum + " números en su interior");

                Console.WriteLine("Ingrese número: ");
                n = int.Parse(Console.ReadLine());
            }

            
        }
    }
}
