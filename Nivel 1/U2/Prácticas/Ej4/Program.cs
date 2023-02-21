using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

            float TF,S;
          
            Console.WriteLine("Ingrese el total facturado: ");
            TF = int.Parse(Console.ReadLine());

            S = (TF*0.05F) + 15000;

            Console.WriteLine("El sueldo final del mulo es de: $" + S.ToString("0.00"));

        }
    }
}
