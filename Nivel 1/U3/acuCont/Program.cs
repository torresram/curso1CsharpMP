using System;

namespace acuCont
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, e1 = 20, e2 = 30, e3 = 15;
            int acumulador = 0;

            if(e1 > 18)
                //contador = contador + 1;
                contador++;
                acumulador += e1;
            if(e2 > 18)
                //contador = contador + 1;
                contador++;
                acumulador += e2;
            if(e3 > 18)
                //contador = contador + 1;
                contador++;
                acumulador += e3;

            Console.WriteLine("El conteo es: " + contador);
            Console.WriteLine("Acumulado: " + acumulador);
        }
    }
}
