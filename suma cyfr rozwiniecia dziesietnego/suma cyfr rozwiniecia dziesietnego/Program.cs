using System;

namespace suma_cyfr_rozwiniecia_dziesietnego
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,robocza;
            robocza = 0;
            a = int.Parse(Console.ReadLine());

            while(a!=0)
            {
                robocza +=  a % 10;
                a /= 10;
            }
            Console.WriteLine(robocza);
            
        }
    }
}
