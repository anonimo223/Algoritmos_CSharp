using System;

namespace Algoritmo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int div = 0;

            Console.WriteLine("Numero Primos menores que 100");
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");

            for (int i = 1; i <= 100; i ++)
            {
                for (int j = 1; j <= i; j ++)
                {
                    if (i % j == 0)
                    {
                        div += 1;
                    }
                }
                if (div == 1 || div == 2)
                {
                    Console.Write(i + " ");
                }
                div = 0;
            }
            Console.ReadLine();
        }
    }
}
