using System;

namespace Algoritmo_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie: S = 1 – 2 + 3 – 4 + 5 – 6 … + n------ \n");
            bool positivo = true;
            string cadena = " ";
            int suma5 = 0;
            for (int p = 1; p <= 10; p++)
            {
                if (positivo)
                {
                    cadena = cadena + " + " + p;
                    positivo = false;
                    suma5 = suma5 + p;
                }
                else
                {
                    cadena = cadena + " - " + p;
                    positivo = true;
                    suma5 = suma5 - p;
                }
            }
            Console.WriteLine(cadena);
            Console.WriteLine("S = " + suma5 + '\n' + '\n');
        }
    }
}
