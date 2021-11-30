using System;

namespace Algoritmo_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Impirmir serie de algoritmos
            //11, 12, 13, 14, 15, 21, 22, 23, 24, 25, 31, 32, 33, 34, 35, 41, 42, 43, 44, 45, 51, 52, 53, 54, 55
            int num = 0;
            int aux = 10;

            Console.WriteLine("=====================");
            Console.WriteLine("Serie de números: ");
            Console.WriteLine("=====================");
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    num = aux + j;
                    Console.Write(num + " ");
                }
                aux = num + 5;
            }

            Console.ReadLine();
        }
    }
}
