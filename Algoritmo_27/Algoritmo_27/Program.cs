using System;

namespace Algoritmo_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie de los N primeros números impares y la suma de ellos.");
            int suma3 = 0;
            for (int o = 1; o <= 10; o += 2)
            {
                Console.WriteLine(o);
                suma3 = suma3 + o;
            }
            Console.WriteLine("La suma de los numeros impares es de: " + suma3 + '\n');
            Console.ReadLine();
        }
    }
}
