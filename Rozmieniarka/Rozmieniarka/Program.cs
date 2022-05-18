using System;

namespace Rozmieniarka
{
    class Program
    {
        struct zamek
        {
            public int a1, a2, a5, a10;
        }
        static void Main(string[] args)
        {
            zamek nominaly(int a)
            {
                zamek alfa;

                alfa.a10 = a / 10; a = a % 10;
                alfa.a5 = a / 5; a = a % 5;
                alfa.a2 = a / 2; a = a % 2;
                alfa.a1 = a / 1;

                
                return alfa;
            }
            int liczba = int.Parse(Console.ReadLine());
            zamek alfa = nominaly(liczba);

            Console.WriteLine("Banknoty 10 zł. : " + alfa.a10);
            Console.WriteLine("Banknoty 5 zł. : " + alfa.a5);
            Console.WriteLine("Banknoty 2 zł. : " + alfa.a2);
            Console.WriteLine("Banknoty 1 zł. : " + alfa.a1);

        }
    }
}
