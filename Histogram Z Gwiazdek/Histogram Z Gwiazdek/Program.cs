using System;

namespace Histogram_Z_Gwiazdek
{
    class Program
    {
        
        static void Main(string[] args)
        {
            void Chart(params int [] t)
            {
                int[] count = new int[6];
                foreach (var item in t)
                    count[item - 1]++;
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("\n"+i + 1 + " ");
                    for (int j = 0; j < count[i]; j++)
                    {
                        Console.Write("*");
                        if (j > 50)
                        {
                            j = count[i] + 1;
                            Console.WriteLine("Za dużo elementów.");
                        }
                    }
                }
            }

            Console.WriteLine("Jak długi ciąg?");
            int a = int.Parse(Console.ReadLine());
            int[] T = new int[a];

            for (int i = 0; i < a; i++)
                T[i] = int.Parse(Console.ReadLine());
            Chart(T);
        }
    }
}
