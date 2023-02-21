using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)//Esta es la funcion principal
        {
            //FUNCIONES --> son un bloque de código.

            //PARTES
            //CABECERA
            //1.TIPO DE DATO
            //2. NOMBRE
            //3. Opcional1: PARAMETROS
            
            //CUERPO
            //Definicion/lógica
            //Opcional: retotno de valor/resultado

            //int n = devolverUno();
            //Console.WriteLine("fin del programa " + devolverUno()); 
          
            int n1=0,n2=0, res;
            
            pedirDatos(ref n1, ref n2);
            /* Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n2 = int.Parse(Console.ReadLine()); */

            //lógica
            //res = a + b;
            res = sumar(ref n1,n2);
            //fin lógica
    
            Console.WriteLine("El resultado es: " + res);
            Console.WriteLine("Gracias por usar esta calculadora poronga");
            
        }
            /* 
            static int devolverUno()
            {
                int nro = 1;
                return nro; 
            }
            */
            
            static int sumar(ref  int n1,int n2)//pueden ir parametros de distinto tipo
            {
                int r;
                r = n1 + n2;
                return r;
            }

            static void pedirDatos(ref int j, ref int h)
            {
                Console.WriteLine("Ingrese un número: ");
                j = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro número: ");
                h = int.Parse(Console.ReadLine());
            }




    }
}
