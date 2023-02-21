using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"

            char[] frase = new char[50];
            char letra, carUno, carDos;
            int i = 0,c = 0;

            Console.WriteLine("Ingrese letra...");
            letra = char.Parse(Console.ReadLine());
            
            while(letra != '.' && i < 50)
            {
                frase[i] = letra;
                letra = char.Parse(Console.ReadLine());
                i++;                
                c++;
            }
            
            Console.WriteLine("Ingrese un caracter");
            carUno = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro caracter");
            carDos = char.Parse(Console.ReadLine());


            for (int x = 0; x < c; x++)
            {
                letra = frase[x];
                if(letra == carUno)
                {
                    letra = carDos;
                    frase[x] = letra;
                }
            }

            for (int x = 0; x < c; x++)
            {
                letra = frase[x];
                Console.Write(letra);
            }

            Console.WriteLine();            
        }
    }
}
