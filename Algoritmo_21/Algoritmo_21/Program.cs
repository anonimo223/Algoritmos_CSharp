using System;

namespace Algoritmo_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 10;
            string cadena4 = " ";
            double elevado = Math.Pow(valor, 2);
            for (int n = 1; n <= valor; n++)
            {
                cadena4 = cadena4 + " + " + n;
            }
            Console.WriteLine(cadena4);
            Console.WriteLine("El resultado es: " + elevado + '\n' + "De la suma de numeros cuadrados.");
            Console.ReadLine();
        }
    }
}
