using System;

namespace Pole_prostopadloscianu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartości 3 boków prostopadłościanu");
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int d;

            d = 2 * (a * b + b * c + a * c);

            Console.WriteLine("Pole prostopadłościanu wynosi "+d);



        }
    }
}
