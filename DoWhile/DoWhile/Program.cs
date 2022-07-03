using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, suma=0;
            bool popr;

            do
            {
                Console.WriteLine("Wprowadż liczbę:");
                popr = int.TryParse(Console.ReadLine(), out a);
                suma = suma + a;
            }

            while (a >= -150 && a <= 150 && popr);

            Console.WriteLine(suma);












        }
    }
}
