using System;

namespace ej_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //DO WHILE este ciclo se usa menos que la verga del papa.

            int n;
            
            do
            {
                Console.WriteLine("Ingrese numero: ");
                n = int.Parse(Console.ReadLine());
            } while (n != 0);
        }
    }
}
