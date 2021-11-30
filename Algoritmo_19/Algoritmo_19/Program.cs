using System;

namespace Algoritmo_19
{
    class Program
    {
        static void Main(string[] args)
        {

            string NOMBRE; 
            Console.Write("Ingrese su nombre : "); 
            NOMBRE = Console.ReadLine(); 
            if (NOMBRE == "Yoongi") 
            { 
                Console.WriteLine(); 
                Console.WriteLine("HOLA"); 
            } 
            else 
            { 
                Console.WriteLine(); 
                Console.WriteLine("NO TE CONOZCO"); 
            }
            Console.WriteLine(); 
            Console.Write("Pulse una Tecla:"); 
            Console.ReadLine();
        }
    }
}
