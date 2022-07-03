using System;

namespace samodzielne_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,suma;
            suma = 0;
            bool czyok;

            do
            {
                Console.WriteLine("Wprowadź liczbę:");
                czyok = int.TryParse(Console.ReadLine(), out a);

                if (czyok == true)
                {
                    if (a > 15)
                        suma++;
                }
                else
                    Console.WriteLine("Wprowadzono błędną wartość.");
            }
            while (a != 0);
            Console.WriteLine("Ilość wprowadzonych liczb, większych od 15: " + suma);
        }
    }
}
