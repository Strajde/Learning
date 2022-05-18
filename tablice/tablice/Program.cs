using System;

namespace tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];
            int m = 0;

            for (int i = 0; i < 10; i++)
            {
                tab[i] = m;
                m++;
            }

            for (int i = 0; i < 10; i++)
                Console.WriteLine(tab[i]);
        }
    }
}
