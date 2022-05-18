using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wielkość nakładu:");

            int a;
            a = int.Parse(Console.ReadLine());

            if (a > 1000)
            {
                int b;
                b = 10 * a;
                Console.WriteLine("Koszt druku wynosi: " + b + "zł.");

            }
            else if (a >= 500 && a <= 1000)
            {
                int c;
                c = 12 * a;
                Console.WriteLine("Koszt druku wynosi: " + c + "zł.");

            }
            else if (a < 500)
            {
                int d;
                d = 15 * a;
                Console.WriteLine("Koszt druku wynosi: " + d + "zł.");

            }
            else
            {

                Console.WriteLine("Błędna wartość.");

            }
        }
    }
}
