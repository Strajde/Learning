using System;

namespace tablicaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = new string[10];

            for (int i = 0; i < 10; i++)
                tab[i] = Console.ReadLine();

            for(int i = 9;i>=0;i--)
                Console.WriteLine(tab[i]);
        }
    }
}
