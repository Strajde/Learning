using System;

namespace choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            int wysokosc,spacje,ilegwiazd;
            ilegwiazd = 1;
            Console.WriteLine("Podaj wysokość choinki:");
            wysokosc = int.Parse(Console.ReadLine());
            spacje = wysokosc - 1;

            for(int i = 1; i<=wysokosc;i++)
            {
                for(int ii = 0;ii<spacje;ii++)
                    Console.Write(" ");
                for(int gwiazdy = 1;gwiazdy<=ilegwiazd;gwiazdy++)
                    Console.Write("*");
                Console.WriteLine();
                ilegwiazd += 2;
                spacje -= 1;
            }
            
        }
    }
}

