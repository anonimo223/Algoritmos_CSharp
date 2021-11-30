using System;

namespace Algoritmo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hallar la suma de un número entero y su inversa.

            string NumCad;
            string invCad = "";

            int num1;
            int num2;
            int r;
            Console.Write("Ingrese un valor numérico: ");
            NumCad = Console.ReadLine();
            num1 = int.Parse(NumCad);


            for(int i = NumCad.Length -1; i > -1; i --)
            {
                invCad += NumCad[i];
            }
            num2 = int.Parse(invCad);

            r = num1 + num2;


            Console.WriteLine();
            Console.WriteLine(num1 + " + ");
            Console.WriteLine(num2);
            Console.WriteLine("------");
            Console.WriteLine(r);

            Console.ReadLine();

        }
    }
}
