using System;

namespace semestral
{
    class Program
    {
        static uint Test1(int a)
        {
            if (a < 10) if (a % 2 == 0) return 1;
                else return 0;
            else if (a % 2 == 0) return 1 + Test1(a / 10);
            else return Test1(a / 10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Test1(75));
        }
    }
}
