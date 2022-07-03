using System;

namespace poletrojkata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz wartości boków trójkąta");

            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            double p, d;
            p = (a + b + c) / 2;
            d = Math.Sqrt(p *(p - a) * (p - b) * (p - c));

            Console.WriteLine("Pole trójkąta {0} {1} {2} wynosi {3}" ,a,b,c,d);
            Console.WriteLine("Pole trójkąta " +a +b +c +"wynosi " +d);


        }
    }
}
