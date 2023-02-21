using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //VECTORES

            /* int n;
            int[] numeros = new int[10]; // declaración

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese la nota: ");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }

            int acu = 0;
            float prom = 0;
            
            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }

            prom = acu / 10;

            //VECTORES DOUBLE

            double[] muestraMatutina = new double[31];
            double[] muestraVespertina = new double[31];
            double[] muestraNocturna = new double[31];

            int dia;
            double temp;

            Console.WriteLine("Cargue el registro matutino");

            for (int x = 0; x < 31; x++)
            {
                Console.WriteLine("Ingrese día: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese temperatura: ");
                temp = double.Parse(Console.ReadLine());

                muestraMatutina[dia - 1] = temp;
            }

            double acuTemp = 0;

            for (int x = 0; x < 31; x++)
            {
                acuTemp += muestraMatutina[x];
            }


            //Otro ejemplo

            double[] sueldos = new double[50];
            int[] legajo = new int[50];

            for (int x = 0; x < 50; x++)
            {
                sueldos[x] = 123;
                legajo[x] = 123;
            }


            //BOOL

            bool[] asistencia = new bool[100];
            int[] legajos = new int[100];
            
            for (int x = 0; x < 16; x++)
            {
                for (int y = 0; y < 100; y++)
                {

                }
            } */

            //CADENAS DE CARACTERES -->

            //char[] frase = new char[10];

            //BARRA CERO
            // \0 --> lo toma como un solo caracter, da fin a una cadena de caracteres.

            //STRING --> Es el tipo de dato cadena de caracteres, detamaño dinámico.
            //VECTOR DE CHAR --> un vector donde se guardan caracteres.

            char[] nombre = new char[11];

            char letra;
            int indice = 0;
            
            Console.WriteLine("Ingrese su nombre: ");
            letra = char.Parse(Console.ReadLine());

            while (letra != '.' && indice < 10)
            {
                nombre[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }

            /* 
                if(indice == 10)
                indice--; 
            */

            nombre[indice - 1] = '\0';

            Console.Write("Hola ");
            indice = 0;

            while(nombre[indice] != '\0')
            {
                Console.Write(nombre[indice]);
                indice++;
            }

            string nombres;

            Console.WriteLine("Ingrese su nombre: ");
            nombres = Console.ReadLine();

            Console.WriteLine("Hola " + nombres);
            
        }   
    }
}
