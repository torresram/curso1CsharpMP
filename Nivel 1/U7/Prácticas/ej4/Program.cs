using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 
            //
            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.

            int[] vArtCV = new int[15];
            int NA, CV, Max = vArtCV[0], Art = 1;

            for (int x = 0; x < 15; x++)
            {
                vArtCV[x] = 0;
            }

            Console.WriteLine("Ingrese número de artículo:");
            NA = int.Parse(Console.ReadLine());
            
            while(NA != 0)
            {
                Console.WriteLine("Ingrese cantidad vendida:");
                CV = int.Parse(Console.ReadLine());
                vArtCV[NA - 1] += CV;
                Console.WriteLine("Ingrese número de artículo:");
                NA = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Las unidades vendidas del artículo 10 son " + vArtCV[9]);

            for (int x = 0; x < 15; x++)
            {
                if(vArtCV[x] == 0)
                    Console.WriteLine("El artículo " + (x + 1) + " no tuvo ventas");
            }

            for (int x = 0; x < 15; x++)
            {
                if(vArtCV[x] > Max){
                    Max = vArtCV[x];
                    Art = x + 1;
                }
            }

            Console.WriteLine("El artículo más vendido es el " + Art + " con " + Max + " unidades vendidas");







        }
    }
}
