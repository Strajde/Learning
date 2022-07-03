using System;

namespace Tabela_ile_razy_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int IleRazyMax = 0;
            int max = tab[0];
            Random los = new Random();

            for (int i = 0; i < 1000; i++)
                tab[i] = los.Next(1, 10000);

            foreach (var element in tab)
                if (max < element)
                {
                    max = element;
                    IleRazyMax++;
                    Console.WriteLine(element);
                }
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Max zmienił się " + IleRazyMax + " razy.");
        }
    }
}
