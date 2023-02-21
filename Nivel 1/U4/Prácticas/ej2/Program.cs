using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

            Si vende menos de 100 litros, no hay descuento.
            Si vende entre 101 y 300 litros, el descuento es del 10%.
            Si vende entre 301 y 500 litros, el descuento es del 15%.
            Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

            Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado.. */

            float L,V;
            V = 160;


            Console.WriteLine("Ingrese cantidad de litros: ");
            L = int.Parse(Console.ReadLine());

            if(L < 100){
                V = V * L;
                Console.WriteLine("No se aplica descuento, abona " + V);
            }
            else if(L > 100 && L <= 300){
                V = (V * 0.9F) * L;
                Console.WriteLine("Se aplica descuento del 10%, abona " + V);
            }else if(L > 300 && L <= 500){
                V = (V * 0.85F) * L;
                Console.WriteLine("Se aplica descuento del 15%, abona " + V);
            }else{
                V = (V * 0.75F) * L;
                Console.WriteLine("Se aplica descuento del 25%, abona " + V);
            }
        }
    }
}
