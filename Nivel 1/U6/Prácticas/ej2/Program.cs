using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            //

            int n, conGrupo = 0,conNum = 0, numGrupo = 0, conGrupoOrd = 0, mayorNum = 0;
            float porcNumImp = 0, maxPorc = 0, conImp = 0;
            bool BI = false, BMayor = false;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                conGrupo = x + 1;
                conImp = 0;
                conNum = 0;
                mayorNum = n;
                Console.WriteLine(mayorNum + " mayor numero actual");
                BMayor = false;

                while(n != 0)
                {
                    Console.WriteLine("Bandera = " + BMayor);
                    conNum++;
                    Console.WriteLine(conNum + " contador de ingresos");
                    if((n % 2 != 0) && (n > 0))
                    {
                        conImp++;
                        Console.WriteLine(conImp + " contador de impares");
                    }    

                    if(n <= mayorNum)
                    {
                        mayorNum = n;
                        Console.WriteLine(mayorNum + " mayor numero actual");
                    }else{
                        BMayor = true;
                    }
                    Console.WriteLine("estado de bandera " + BMayor);
                    Console.WriteLine("Ingrese un número: ");
                    n = int.Parse(Console.ReadLine());
                }
                
                Console.WriteLine(conImp + " fin del while");
                Console.WriteLine(conNum + " fin del while");
                Console.WriteLine(BMayor + " estado bandera");

                if(BMayor == false)
                {
                    conGrupoOrd++;
                    Console.WriteLine(conGrupoOrd + " contador ordenados");
                }

                porcNumImp = conImp * 100 / conNum;
                Console.WriteLine(porcNumImp.ToString("0.00%") + " porcentaje de impares");

                if(BI == false)
                {
                    maxPorc = porcNumImp;
                    BI = true;
                    numGrupo = conGrupo;
                    Console.WriteLine(maxPorc + " porcentaje maximo");
                    Console.WriteLine(conGrupo + " contador de grupo");
                }else if(porcNumImp > maxPorc){
                    maxPorc = porcNumImp;
                    numGrupo = conGrupo;
                    Console.WriteLine(maxPorc + " porcentaje Maximo");
                    Console.WriteLine(conGrupo + " contador de Grupo");
                }

                
            }

            Console.WriteLine("El número de grupo con mas impares dentro es el " + numGrupo);
            Console.WriteLine("La cantidad de grupos ordenados de mayor a menor es " + conGrupoOrd);
        }
    }
}

//798,456,356,215,150 ord
//34,78,59,38,15
//89,76,65,54,42 ord
//98,65,51,32,21 ord +impares
//15,78,98,22,11