using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

            int cv = 0;
            float p = 0, montoTotal;

            ingresoValores(ref p, ref cv);
            
            montoTotal = producto(p,cv);

            Console.WriteLine("El monto total de la operación es $" + montoTotal);
        }

        static float producto(float a, int b)
        {
            float p;
            p = a * b;
            return p;
        }

        static void ingresoValores(ref float precio, ref int cantidad)
        {
            Console.WriteLine("Ingrese precio:");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad");
            cantidad = int.Parse(Console.ReadLine());
        }
    }
}
