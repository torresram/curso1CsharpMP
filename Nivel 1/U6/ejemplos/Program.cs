using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //CICLOS COMBINADOS 

            //FOR CON FOR

            //int prom,acu,n, con;


            /* for (int y = 0; y < 10; y++)
            {
                acu = 0;
                for (int x = 0; x < 20; x++)
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    acu += n;        
                }
                prom = acu / 20;
                Console.WriteLine("El promedio es: " + prom); */

            //FOR CON WHILE
            /* 
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                
                acu = 0;
                con = 0;
                
                while(n != 0){
                    acu += n;
                    con++;
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                }
                    prom = acu / con;
                    Console.WriteLine("El promedio es: " + prom);            
            }
            */

            //CORTE DE CONTROL

            int legajo, edad, codigoEquipo, equipoActual;
            float sueldo;

            Console.WriteLine("Ingrese el legajo: ");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo: ");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigod de equipo: ");
            codigoEquipo = int.Parse(Console.ReadLine());

            while (sueldo > 0)
            {
                equipoActual = codigoEquipo;
                while (codigoEquipo == equipoActual)
                {
                    Console.WriteLine("Ingrese el legajo: ");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese edad: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo: ");
                    sueldo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el codigod de equipo: ");
                    codigoEquipo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}

