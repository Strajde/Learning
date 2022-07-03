using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];

            for (int i = 0; i < 10; i++)
                tab[i] = int.Parse(Console.ReadLine());

            foreach (var czastka in tab)
            {
                if (czastka % 2 == 0)
                    Console.WriteLine(czastka);


            }
        }
    }
}
