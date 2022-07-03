using System;

namespace compare
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            do
            {
                 a = Console.ReadLine();
                 b = Console.ReadLine();
            }
            while(string.Compare(a,b,true)!= 0);
        }
    }
}
