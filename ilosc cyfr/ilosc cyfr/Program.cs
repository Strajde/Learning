
using System;

namespace ilosc_cyfr
{
    class Program
    {
        static void Main(string[] args)
        {
            int iloscCyfr(int a)
            {
                int w = 0;
                while (a != 0)
                {
                    w++;
                    a /= 10;
                    Console.WriteLine(a);
                    
                }
                return w;
            }
                int x;
                x = int.Parse(Console.ReadLine());
                Console.WriteLine(iloscCyfr(x));
            
        }
    }
}
