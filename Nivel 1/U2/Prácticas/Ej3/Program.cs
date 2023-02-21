using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo.        Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados

            float km,vel,tiempo;

            Console.WriteLine("Ingrese la distancia(Km): ");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese velocidad(km/h): ");
            vel = float.Parse(Console.ReadLine());

            tiempo = km / vel;

            Console.WriteLine("El tiempo estimado es de: " + tiempo.ToString("0.00") + " horas");


        }
    }
}
