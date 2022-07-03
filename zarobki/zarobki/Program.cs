using System;

namespace zarobki
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool liczba;
            liczba = int.TryParse(Console.ReadLine(), out a);
            
            if (liczba)
            {
                if (a > 50)
                {
                    int b;
                    b = a * 30;

                    Console.WriteLine(b + "zł.");
                }
                else if (a <= 50)
                {
                    int c;
                    c = a * 20;

                    Console.WriteLine(c + "zł.");
                }
            }
            else
            {
                Console.WriteLine("Błędna wartość.");
            }
        }
    }
}
