using System;

namespace suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;
            Console.WriteLine(a+"+"+b+"="+c);
            Console.WriteLine(a + "-" + b + "=" + d);
            Console.WriteLine(a + "*" + b + "=" + e);
            Console.WriteLine(a + "/" + b + "=" + f);

        }
    }
}
