using System;

namespace tablica10x10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[10, 10];
            Random los = new Random();
            

            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                    tab[a, b] = los.Next(0, 1001);

            }
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    Console.Write(tab[a, b] + "\t");  
                    
                }
                Console.WriteLine();
            }
            

        }
    }
}
