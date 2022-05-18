using System;

namespace tablica_1000_każda_mniejsza_od_100_wieksza_o_10000
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            Random los = new Random();

            for (int i = 0; i < 1000; i++)
                tab[i] = los.Next(-100, 1000);
            for (int i = 0; i < 1000; i++)
                if (tab[i] < 100)
                    tab[i] += 10000;
            foreach(var element in tab)
                Console.WriteLine(element);



        }
    }
}
