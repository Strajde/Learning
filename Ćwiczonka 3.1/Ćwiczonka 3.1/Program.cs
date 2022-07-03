using System;

namespace Ćwiczonka_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, nwd, c;


            Console.WriteLine("Podaj pierwszą liczbę: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            b = int.Parse(Console.ReadLine());

            if (b != 0)
            {
                if (a % b == 0)
                {
                    nwd = b;
                    Console.WriteLine(a + " % " + b + " = " + "0");
                    Console.WriteLine("Największy wspólny dzielnik to: " + nwd);
                }
                else
                {
                    while (a % b != 0)
                    {
                        c = a % b;
                        Console.WriteLine(a + " % " + b + " = " + c);
                        a = b;
                        b = c;

                    }
                    Console.WriteLine("Największy wspólny dzielnik to: " + b);
                }

            }
            else
                Console.WriteLine("Próba dzielenia przez 0");
        }
    }
}
