using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

            Si el importe es menor a ARS 1000, no hay descuento.
            Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.*/

            float I,IF;

            Console.WriteLine("Ingrese importe: ");
            I = float.Parse(Console.ReadLine());

            if(I > 100 && I < 5000)
                IF = I * 0.9F;
            else if(I > 5000)
                IF = I * 0.82F;
            else
                IF = I;
            
            Console.WriteLine("El importe final es: " + IF.ToString("$0.00"));


        } 
           

    }
}
