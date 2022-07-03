using System;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczby działania:");

            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("1 - dodawanie");
            Console.WriteLine("2 - odejmowanie");
            Console.WriteLine("3 - mnożenie");
            Console.WriteLine("4 - dzielenie");

            int c;
            c = int.Parse(Console.ReadLine());

            if (c == 1)
            {
                double d;
                d = a + b;
                Console.WriteLine(a + "+" + b + "=" + d);
            }
            else if (c == 2)
            {
                double d;
                d = a - b;
                Console.WriteLine(a + "-" + b + "=" + d);
            }
            else if (c == 3)
            {
                double d;
                d = a * b;
                Console.WriteLine(a + "*" + b + "=" + d);
            }
            else if (c == 4 && b == 0 || a == 0)
            {
                Console.WriteLine("Dzielenie przez 0.");
            }
            else if (c == 4)
            {
                double d;
                d = a / b;
                Console.WriteLine(a + "/" + b + "=" + d);
            }
            else
            {
                Console.WriteLine("Błędna wartość.");

            }
        }
    }
}
