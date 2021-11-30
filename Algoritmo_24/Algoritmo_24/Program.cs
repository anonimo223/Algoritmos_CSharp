using System;

namespace Algoritmo_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie: ------S = 1/1 + 1 / 3 + 1 / 5 + 1 / 7 + 1 / N---------\n");
            int suma6 = 0;
            string cadena2 = " ";
            for (int j = 1; j <= 10; j += 2)
            {
                cadena2 = cadena2 + "1/" + j + " + ";
                suma6 = suma6 + j;
            }
            Console.WriteLine(cadena2);
            Console.WriteLine("S = " + suma6 + '\n' + '\n');
        }
    }
}
