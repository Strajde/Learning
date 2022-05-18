using System;

namespace zad4_NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("NWD:");

            while(a != b)
            {
                if(a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }

            }
            Console.WriteLine(a);
        }
    }
}
