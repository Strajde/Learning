using System;

namespace parzyste_nieparzyste
{
    class Program
    {
        public struct wynik
        {
            public int parzyste, nieparzyste;
        }

        static wynik obliczarka(int[] tab)
        {
            wynik a;
            a.parzyste = 0;
            a.nieparzyste = 0;

            Console.Write("%2:\t");
            foreach(var item in tab)
            {
                if (tab[item] % 2 == 0)
                {
                    a.parzyste++;
                    Console.Write(tab[item] % 2 + "\t");
                }
                else
                {
                    a.nieparzyste++;
                    Console.Write(tab[item] % 2 + "\t");
                }

            }
            Console.WriteLine("\n");
            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj długość tabeli: ");
            int a = int.Parse(Console.ReadLine());
            Random los = new Random();
            int[] tab = new int[a];

            Console.Write("\n\t");
            for (int x = 0; x < tab.Length; x++)
            {
                tab[x] = los.Next(1, 101);
                Console.Write(tab[x] + "\t");
            }
            Console.WriteLine();
            wynik b = obliczarka(tab);
            Console.WriteLine("Parzyste : " + b.parzyste);
            Console.WriteLine("Nieparzyste : " + b.nieparzyste);
        }
    }
}
