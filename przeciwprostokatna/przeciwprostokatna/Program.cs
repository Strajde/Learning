using System;

namespace przeciwprostokatna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartości 2 boków trójkąta");

            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            double d;

            
            d = Math.Sqrt(a * a + b * b);

            Console.WriteLine("Przeciwprostokątna wynosi"+d);

        }
    }
}
