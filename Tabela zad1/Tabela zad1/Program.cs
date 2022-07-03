using System;

namespace Tabela_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int max = tab[0];
            int rozpietosc = 0;
            Random los = new Random();

            for (int i = 0; i < 1000; i++)
                tab[i] = los.Next(-20000, 20000);
            foreach (var element in tab)
                if (element > max)
                    max = element;
            int min = tab[0];
            foreach (var element in tab)
                if (element < min)
                    min = element;
            rozpietosc = max + -min;
            Console.WriteLine("Rozpiętość zbioru: " + rozpietosc);
        }
    }
}
