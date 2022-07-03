using System;

namespace pierwsza_pierwiastek
{
    class Program
    {
        static bool Prime(int n)
        {
            if (n < 2) 
                return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Prime(101));
        }
    }
}
