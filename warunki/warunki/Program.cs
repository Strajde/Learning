using System;

namespace warunki
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, robocza, c;
            a = double.Parse(Console.ReadLine);
            b = double.Parse(Console.ReadLine);

            robocza = (a + b) * (a + b);

            if (robocza == 0) ;
            {
                Console.WriteLine("Dzielenie przez 0 jest niemożliwe");

                else 
                    c =((a * a + b) / robocza);
                Console.WriteLine(c);
            }

        }
    }
}
