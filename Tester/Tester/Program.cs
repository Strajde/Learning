using System;
using System.Diagnostics;
using System.IO;
using System.Numerics;
namespace Tester
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Random los = new Random(Guid.NewGuid().GetHashCode());
            int[] tab = new int[10];

            for (int x = 0; x < 10; x++)
            {
                tab[x]  = los.Next(10);
                Console.WriteLine(tab[x]);
            }
            string a = tab[5].ToString();
            Console.WriteLine(a.GetHashCode());

        }
    }
}
