using System;

namespace raty
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            bool liczbaa, liczbab;
            Console.WriteLine("Wporowadż wartość produktu.");
            liczbaa = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Wprowadź ilość rat (6-36)");
            liczbab = double.TryParse(Console.ReadLine(), out b);


            if (liczbaa && liczbab )
            {
                if (b >=6 && b <= 12 )
                {
                    double c, wynik;
                    c = a * 1.02;
                    wynik = c / b;
                    Console.WriteLine(wynik);

                }
                else if (b > 12 && b <= 24)
                {
                    double d,wynik;
                    d = a * 1.05;
                    wynik = d / b;
                    Console.WriteLine(wynik);
                }

                 else if (b > 24 && b <= 36)
                {
                    double e, wynik;
                    e = a * 1.1;
                    wynik = e / b;
                    Console.WriteLine(wynik);
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa ilość rat");
                }
            }
            else
            {
                Console.WriteLine("Podaj wartość.");
            }

        }
    }
}
