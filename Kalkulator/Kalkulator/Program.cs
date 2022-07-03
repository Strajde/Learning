using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char dzialanie;
            double a, b;

            Console.WriteLine("Podaj pierwszą liczbę działania");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę działania");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Jakie działanie wykonać?");
            dzialanie = char.Parse(Console.ReadLine());

            switch (dzialanie)
            {
                case '+':
                    double c;
                    c = a + b;
                    Console.WriteLine("c");
                    break;
                case '-':
                    double d;
                    d = a - b;
                    Console.WriteLine("d");
                    break;
                case '*':
                    double e;
                    e = a * b;
                    Console.WriteLine("e");
                    break;
                case '/':
                    if (a != 0 && b != 0)
                    {
                        double f;
                        f = a / b;
                        Console.WriteLine("f");
                    }
                    else
                    {
                        Console.WriteLine("Dzielenie przez 0");
                    }
                    break;



            }
        }
    }
}
