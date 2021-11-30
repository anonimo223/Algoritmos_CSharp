using System;

namespace Algoritmo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numRand = rnd.Next(1, 6);
            int chance = 2;


            for (int i = 1; i <= chance; i++)
            {

                Console.Write("INGRESA UN NUMERO DEL 1 AL 5: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == numRand)
                {
                    Console.WriteLine("¡¡¡ACERTASTE!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("¡¡¡INCORRECTO!!!");
                }

                if (chance == i)
                {
                    Console.WriteLine("SE ACABARON TUS INTENTOS");
                }
            }

        }
    }
}
