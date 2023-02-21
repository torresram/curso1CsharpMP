using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

            int n,MP,MI;
            bool BP,BI;
            BP = false;
            BI = false;
            MP = 0;
            MI = 0;
            
            for (int x = 0; x < 20; x++){
                
                Console.WriteLine("Ingrese número: ");
                n = int.Parse(Console.ReadLine());

                if((n % 2) == 0) {
                    if(BP == false){
                        MP = n;
                        BP = true;
                    }else{
                        if(n > MP)
                            MP = n;
                    }
                }else if(!BI){
                    MI = n;
                    BI = true;
                }else if(n < MI){
                    MI = n;
                }
            }

            Console.WriteLine("El máximo par es " + MP);
            Console.WriteLine("El mínimo impar es " + MI);
        }
    }
}