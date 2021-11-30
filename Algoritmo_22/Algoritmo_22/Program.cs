using System;

namespace Algoritmo_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir la tabla del 9 UwU.");
            int tabla_Nueve = 9;
            for (int h = 1; h <= tabla_Nueve; h++)
            {
                int multi_tabla = tabla_Nueve * h;
                Console.WriteLine(tabla_Nueve + " * " + h + " = " + multi_tabla + '\n');
            }
            Console.ReadLine();
        }
    }
}
