using System;

namespace Algoritmo_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("factorial de un número");
            int factotial = 16; //Numero
            int valor = 10;
            for (int u = 1; u <= valor; u++)
            {
                Console.WriteLine(u);
                factotial = factotial * u;
            }
            Console.WriteLine("El factorial de" + valor + " es: " + factotial + '\n');
            Console.ReadLine();
        }
    }
}
