using System;

namespace MaxTabelaLosowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int max = tab[0];
            Random los = new Random();

            for (int i = 0; i < 1000; i++)
                tab[i] = los.Next(1, 1000);

            foreach (var element in tab)
                if (element > max)
                    max = element;
            Console.WriteLine(max);
            


        }
    }
}
