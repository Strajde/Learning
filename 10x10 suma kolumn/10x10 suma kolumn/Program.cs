using System;

namespace _10x10_suma_kolumn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[10, 10];
            int[] suma = new int[10];
            Random los = new Random();

            for(int x = 0; x<10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    tab[x, y] = los.Next(0,9);
                    Console.Write(tab[x,y] + "\t");
                    suma[y] += tab[x, y];
                }
                Console.WriteLine("\n");            
            
            }
            foreach(var element in suma)
                Console.Write(element + "\t");
        }
    }
}
