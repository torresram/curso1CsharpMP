using System;

namespace switch_ej
{
    class Program
    {
        static void Main(string[] args)
        {
            //SWITCH

            char letra = 'A';

            switch(letra){
                case 'M':
                    Console.WriteLine("Nombre con M");
                    break;
                case 'H':
                    Console.WriteLine("Nombre con H");
                    break;
                case 'R':
                    Console.WriteLine("Nombre con R");
                    break;
                default:
                    // tu mama en tanga
                    break;
            }
        }
    }
}
