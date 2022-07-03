using System;

namespace liczbaslownie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (c > 0)
            {
                d = (a * a + b);
                Console.WriteLine(d);
            }

            else if (c < 0) 
            {
                d = (a - b * b);
                Console.WriteLine(d);
            }

            else
            {
                d = 1 / (a - b);
                Console.WriteLine(d);
            }


           

        }
    }
}
