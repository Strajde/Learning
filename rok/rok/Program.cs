using System;

namespace rok
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool liczba;
            liczba = int.TryParse(Console.ReadLine(), out a);

            if (a%400==0)
            {
                Console.WriteLine("Rok jest przestępny.");
            }
            else if (a%100==0)
            {
                Console.WriteLine("Rok nie jest przestępny");
            }
            else if (a % 4 == 0)
            {
                Console.WriteLine("Rok jest przestępny");
            }
            else
            {
                Console.WriteLine("Rok nie jest przestępny");
            }
        }
    }
}
