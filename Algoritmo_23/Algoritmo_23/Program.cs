using System;

namespace Algoritmo_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ejercicio 16: ------S = 1 + 2 – 3 + 4 + 5 – 6 + 7 + 8 + 9 + … + N-----\n");
            int suma88 = 0;
            string cadenas44 = " ";
            int positivosactualess2 = 0;
            int cantidadpositivoss2 = 1;
            for (int cont = 1; cont <= 10; cont++)
            {

                if (positivosactualess2 < cantidadpositivoss2)
                {
                    cadenas44 = cadenas44 + " + " + cont;
                    positivosactualess2 = positivosactualess2 + 1;
                    suma88 = suma88 + cont;
                }

                else
                {
                    cadenas44 = cadenas44 + " - " + cont;
                    positivosactualess2 = 0;
                    suma88 = suma88 - cont;
                    cantidadpositivoss2 = cantidadpositivoss2 + 1;
                }
            }
            Console.WriteLine(cadenas44);
            Console.WriteLine("S = " + suma88 + '\n' + '\n');
        }
    }
}
