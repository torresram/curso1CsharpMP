using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

            //a. 1 si el número es positivo.
            //b. -1 si el número es negativo.
            //c. 0 si el número es cero.

            int n1, p = 0, n = 0, c = 0, pnc = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n1 = int.Parse(Console.ReadLine());

                positNegCero(n1,ref pnc);

                if(pnc == 1)
                    p++;
                else if(pnc == -1)
                    n++;
                else
                    c++;
            }

            Console.WriteLine("La cantidad de positivos es " + p + ", la cantidad de negativos es " + n + ", la cantidad de ceros es " + c);
        }

        static void positNegCero(int a,ref int PNC)
        {
            if(a > 0)
                PNC = 1;
            else if(a < 0)
                PNC = -1;
            else
                PNC = 0;
        }
    }
}
