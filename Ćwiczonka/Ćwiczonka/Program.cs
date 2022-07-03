using System;

namespace Ćwiczonka
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            double c;
           
            Console.WriteLine("Podaj pierwszą liczbę działania");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę działania");
            b = float.Parse(Console.ReadLine());

            if (Math.Pow(a + b, 2) != 0)
            {
                c = (a * a + b) / Math.Pow(a + b, 2);
                Console.WriteLine("Wynik: " + c);
            }
            else
                Console.WriteLine("Próba dzielenia przez 0.");
        }
    }
}
