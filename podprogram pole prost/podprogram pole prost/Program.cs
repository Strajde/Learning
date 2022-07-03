using System;

namespace podprogram_pole_prost
{
    class Program
    {
        static double pole(double a, double b)
        {
            double po;
            po = a * b;
            return po;
        }

        
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double p = pole(a, b);
            Console.WriteLine(p);

            
        }
    }
}
