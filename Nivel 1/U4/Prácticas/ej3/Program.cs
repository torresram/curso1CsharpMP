﻿using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
	                    i5 (1) 	     i7 (2)	      i9 (3)
            8 RAM (1) 	USD 800 	USD 900 	USD 1200
            16 RAM (2) 	USD 900 	USD 1000 	USD 1400
            32 RAM (3) 	USD 1000 	USD 1400 	USD 2000

            Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada. */

            int OP,OM,OD,precio;
            precio = 0;
            
            Console.WriteLine("Elija Procesador: ");
            OP = int.Parse(Console.ReadLine());
            Console.WriteLine("Elija Memoria: ");
            OM = int.Parse(Console.ReadLine());
            Console.WriteLine("Elija Disco: ");
            OD = int.Parse(Console.ReadLine());
            
            switch(OP){
                case 1:
                    switch(OM){
                        case 1:
                            precio = 800;
                            break;
                        case 2:
                            precio = 900;
                            break;
                        case 3:
                            precio = 1000;
                            break;
                    }
                break;
                
                case 2:
                    switch(OM){
                        case 1:
                            precio = 900;
                            break;
                        case 2:
                            precio = 1000;
                            break;
                        case 3:
                            precio = 1400;
                            break;                
                    }
                break;

                case 3:
                    switch(OM){
                        case 1:
                            precio = 1200;
                            break;
                        case 2:
                            precio = 1400;
                            break;
                        case 3:
                            precio = 2000;
                            break;
                    }
                break;
            }

            if(OD == 1)
                precio = precio + 300;
            
            Console.WriteLine("El precio final es: " + precio);
        }
    }
}
