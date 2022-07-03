using System;

namespace Tabele_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[3000];
            int sumaparzystych = 0, sumanieparzystych = 0;
            Random los = new Random();

            for (int i = 0; i < 3000; i++)
            {
                tab[i] = los.Next(-1000, 1000);
                if (i % 2 == 0)
                    if (tab[i] % 2 == 0)
                        sumaparzystych += tab[i];
                if (i % 2 != 0)
                    if (tab[i] % 2 != 0)
                        sumanieparzystych += tab[i];

            }
            Console.WriteLine("Suma liczb parzystych z indeksów parzystych: " + sumaparzystych);
            Console.WriteLine("Suma liczb nieparzystych z indeksów nieparzystych: " + sumanieparzystych);

        }
    }
}
