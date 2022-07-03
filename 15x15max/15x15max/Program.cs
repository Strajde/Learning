using System;

namespace _15x15max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[15, 15];
            Random los = new Random();
            int x = 0;
            int y = 0;
            int max = 0;

            for (int a = 0; a < 15; a++)
                for (int b = 0; b < 15; b++)
                {
                    tab[a, b] = los.Next(1, 100000);
                    if (max < tab[a, b])
                    {
                        max = tab[a, b];
                        x = b + 1;
                        y = a + 1;
                    }
                }   
            for (int a = 0; a < 15; a++)
            {
                for (int b = 0; b < 15; b++)
                    Console.Write(tab[a, b] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Współrzędne: " + x + "," + y);
        }
    }
}
