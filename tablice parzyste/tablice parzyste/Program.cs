using System;

namespace tablice_parzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];

            for (int i = 0; i < 10; i++)
                tab[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Parzyste wartości w tablicy:");
            
            for (int i = 0; i < 10; i++)
            {
                if (tab[i] % 2 ==0)
                    Console.WriteLine(tab[i]);
            }


        }
    }
}
