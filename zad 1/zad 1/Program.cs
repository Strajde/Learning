using System;

namespace zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[20];
            int[] tab2 = new int[10];
            Random los = new Random();

            for (int i = 0; i < 10; i++)
            {
               
            }


            for (int i = 0; i < 20; i++)
            {
                tab[i] = los.Next(1, 11);
                for (int j = 0; j < 10; j++)
                {
                    if (tab[i] == j + 1)
                        tab2[j]++;

                }                
            }
            Console.Write("Wylosowane liczby: ");
            for (int i = 0; i < 20; i++)
                Console.Write(tab[i]+" ");

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j+1 + ". " + tab2[j]);
            }

        }
    }
}
