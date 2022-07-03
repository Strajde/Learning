using System;

namespace _8._1
{
    class Program
    {
        static void srednia(int[] tab, int a)
        {
            double suma = 0;
            double srednia;

            for (int x = 0; x < a; x++)
            {
                suma += tab[x];
            }
            srednia = suma / a;

            Console.Write("Średnia z liczb: ");
            foreach (var item in tab)
                Console.Write(item + " ");
            Console.WriteLine("wynosi {0}.",srednia);
            

        }
        static void Main(string[] args)
        {
            

            Console.WriteLine("Wprowadź długość ciągu liczb: ");
            int a = int.Parse(Console.ReadLine());
            int[] tab = new int[a];

            for (int x = 0; x < a; x++)
            {
                tab[x] = x + 1;
            }

            if (a > 0)
            {
                srednia(tab, a);
            }
            else
                Console.WriteLine("Wiecej niz \"0\" proszę. Dziękuję. Z \"0\" i tak cała zabawa nie ma sensu.");
        }
    }
}
