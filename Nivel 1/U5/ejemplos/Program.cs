using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // CICLO FOR
            int cont;
            cont = 0;

            for (int i = 0; i < 120; i++)
            {
                cont++;
                Console.WriteLine("Esto es un ciclo FOR " + cont);
            }
        }
    }
}
