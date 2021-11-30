using System;

namespace Algoritmo_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leer el valor de N, imprimir y sumar los números de 1 a N.");
            int suma1 = 0;
            string numeroC;
            Console.WriteLine("ingresa cantidad: ");
            numeroC = Console.ReadLine();
            int cantidad = Convert.ToInt32(numeroC);

            for (int y = 1; y <= cantidad; y++)
            {
                Console.WriteLine(y);
                suma1 = suma1 + y;
            }
            Console.WriteLine("La suma de los numeros es: " + suma1 + '\n');
            Console.ReadLine();
        }
    }
}
