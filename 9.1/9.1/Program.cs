using System;

namespace _9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random los = new Random();
            int[] tab = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tab[i] = 0;
            }

            for (int i = 0; i < 1000; i++)
            {
                int a = los.Next(1,11);

                switch (a)
                {
                    case 1: tab[0]++; break;
                    case 2: tab[1]++; break;
                    case 3: tab[2]++; break;
                    case 4: tab[3]++; break;
                    case 5: tab[4]++; break;
                    case 6: tab[5]++; break;
                    case 7: tab[6]++; break;
                    case 8: tab[7]++; break;
                    case 9: tab[8]++; break;
                    case 10: tab[9]++; break;
                    default: Console.WriteLine("kogut"); break;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + " : " + tab[i]);
            }
            int x = 0;
            for (int i = 0; i < 10; i++)
                x +=tab[i];
            Console.WriteLine(x);
        }
    }
}
