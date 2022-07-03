using System;

namespace czypierwsza
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool czy = true;
            Console.WriteLine("Podaj liczbę do sprawdzenia:");
            a = int.Parse(Console.ReadLine());

            for(int i = 2;i*i<=a;i++)
            {
                if (a % i == 0)
                    czy = false;
            }
            if(czy==true)
                Console.WriteLine("Jest pierwsza.");
            else
                Console.WriteLine("Nie jest pierwsza.");
        }
    }
}

