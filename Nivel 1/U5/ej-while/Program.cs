using System;

namespace ej_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHILE
            int n, con = 0;
            
            Console.WriteLine("Mete un numerito...");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                Console.WriteLine("Mete un numerito...");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingresaron " + con + " números.");
        }
    }
}
