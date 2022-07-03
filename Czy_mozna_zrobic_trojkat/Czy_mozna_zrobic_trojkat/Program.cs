using System;

namespace Czy_mozna_zrobic_trojkat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool prawidlowo,trojkat;

            Console.WriteLine("Podaj pierwszy bok trójkąta: ");
            prawidlowo = int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Podaj drugi bok trójkąta: ");
            prawidlowo = int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Podaj trzeci bok trójkąta: ");
            prawidlowo = int.TryParse(Console.ReadLine(), out c);

            if(prawidlowo==true)
            {
                trojkat = a + b > c && a + c > b && b + c > a;
                if(trojkat==true)
                    Console.WriteLine("Z tych odcinków może powstać trójkąt.");
                else
                    Console.WriteLine("Z tych odcinków nie może powstać trójkąt.");
            }
            else
            {
                Console.WriteLine("Podano błędne wartości.");
            }
        }
    }
}
