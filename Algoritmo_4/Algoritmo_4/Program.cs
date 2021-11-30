using System;

namespace Algoritmo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string numcad;
            char num;
            int aux;
            long oper;
            int iLength;
            long iResult = 0;
            int contNotBin = 0;
            Console.WriteLine("Convertir de Binario a Decimal: ");
            Console.WriteLine("================================= ");
            Console.WriteLine();
            Console.WriteLine("Escribe un numero en binario: ");
            numcad = Console.ReadLine();
            iLength = numcad.Length;
            iLength--;

            for (int i = 0; i < numcad.Length; i ++, iLength--)
            {
                num = numcad[i];
                aux = Convert.ToInt32(num);

                if (((aux - 48) == 1) | ((aux - 48) == 0))
                {
                    oper = (long)Math.Pow(2, iLength);
                    iResult = iResult + (long)(aux - 48) * oper;
                }
                else
                {
                    contNotBin += 1;
                }
            }
            Console.WriteLine();
             
            if (contNotBin > 0)
            {
                Console.Write(numcad + "No es un numero Binario :)");
            } 
            else
            {
                Console.Write("Valor decimal de " + numcad + " = " + iResult);
            }
            Console.ReadLine();
        }
    }
}
