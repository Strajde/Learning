using System;

namespace pole_trapezu
{
    class Program
    {
        static void pole(int a, int b, int c)
        {
            double x;
            x = a + b * c * 0.5;
            Console.WriteLine("Pole trapezu wynosi {0}.", x);
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Podaj długości pierwszej podstawy: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długości drugiej podstawy: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokość: ");
            c = int.Parse(Console.ReadLine());
            pole(a, b, c);
        }
    }
}
