using System;

namespace Cwiczonka_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,wynik;
            Console.WriteLine("Podaj pierwszą liczbe działania");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbe działania");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bardzo ważną wartość \"c\", od której wszystko zależy");
            c = double.Parse(Console.ReadLine());

            if (c > 0)
            {
                wynik = Math.Pow(a, 2) + b;
                Console.WriteLine("Wynik: " + wynik);
            }
            else if(c < 0)
            {
                wynik = a - Math.Pow(b, 2);
                Console.WriteLine("Wynik: " + wynik);
            }
            else
            {
                if(a -b != 0)
                {
                    wynik = 1 / (a - b);
                    Console.WriteLine("Wynik: " + wynik);
                }
                else
                    Console.WriteLine("Próba dzielenia przez 0.");
            }


        }
    }
}
