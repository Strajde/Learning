using System;

namespace bool_prime
{
    class Program
    {
        static bool Prime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 0; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
            Console.WriteLine(Prime(n));
        }
        static bool blizniacza(int n)
        {
            if (Prime(n - 2) || Prime(n + 2)) return true;
            return false;
        }
            
        static void Main(string[] args)
        {
            
        }
    }
}
