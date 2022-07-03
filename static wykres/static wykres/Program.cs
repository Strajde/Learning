using System;

namespace static_wykres
{
    class Program
    {
        static void wykres(int[])
        {
            Random los = new Random();
            int[] tab = new int[4];
            for (int i = 0; i < 4; i++)
                tab[i] = los.Next(0,9);
        }
        static void gwiazdy(int n)
        {
           if(n<71)
            for (int i = 0; i < n; i++)
            {
                Console.Write(n + " ");
                Console.Write("*");
                Console.WriteLine();
            }
            else
            {
                Console.Write(n + " ");
                Console.Write("**********************************************************************...");
                Console.WriteLine();
            }

        static void Main(string[] args)
        {
           
        }
    }
}
