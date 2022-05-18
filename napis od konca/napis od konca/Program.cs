using System;

namespace napis_od_konca
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();

            for(int i = a.Length-1;i >= 0; i--)
                Console.Write(a[i]);

        }
    }
}
