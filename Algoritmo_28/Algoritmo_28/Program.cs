using System;

namespace Algoritmo_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de los primeros N números pares.");
            int suma2 = 0;
            for (int e = 2; e <= 10; e += 2)
            {
                Console.WriteLine(e);
                suma2 = suma2 + e;
            }
            Console.WriteLine("La suma de los numeros pares es: " + suma2 + '\n');
            Console.ReadLine();
        }
    }
}
