using System;

namespace Tablica____
{
    class Program
    {
        static bool CzyWzgledniePierwsza(int a, int b)
        {
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            if (a == 1) return true;
            else return false;

        }
        static void Main(string[] args)
        {
            

            Console.WriteLine("Wprowadź wielkość matrycy(1-30): ");
            int a = int.Parse(Console.ReadLine());
            bool[,] Tab = new bool[a, a];

            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < a; y++)
                {
                    Tab[x, y] = CzyWzgledniePierwsza(x + 1, y + 1);
                    if (Tab[x, y]) Console.Write("+\t");
                    else Console.Write("-\t");
                }
                Console.WriteLine();
            }
        }
    }
}
