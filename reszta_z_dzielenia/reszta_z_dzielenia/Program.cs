using System;

namespace reszta_z_dzielenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool liczba;

            Console.WriteLine("Podaj liczbę:");
            liczba = int.TryParse(Console.ReadLine(), out a);

            if(liczba)
            {
                if(a%100 > 49)
                    Console.WriteLine("Druga cyfra liczby jest większa od 4");

                        else
                    Console.WriteLine("Druga cyfra liczby nie jest większa od 4");
            }
            else
                Console.WriteLine("Błedna wartość.");
        }
    }
}
