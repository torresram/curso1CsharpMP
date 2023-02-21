using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Hacer un programa que solicite el ingreso de dos números y luego calcular:

            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.

            Se deberá emitir un cartel por pantalla con el resultado correspondiente.
 */
            int a,b,R,S,P;

            Console.WriteLine("Ingrese número 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 2: ");
            b = int.Parse(Console.ReadLine());

            if(a > b){
                R = a - b;
                Console.WriteLine("La resta da: " + R);
            }else if(a == b){
                S = a + b;
                Console.WriteLine("La suma es: " + S);
            }else{
                P = a * b;
                Console.WriteLine("El producto es: " + P);
            }
        }
    }
}
