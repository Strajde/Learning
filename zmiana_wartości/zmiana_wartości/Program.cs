using System;

namespace zmiana_wartości
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jednostki długości:");
            Console.WriteLine("a. mile --> km");
            Console.WriteLine("b. jardy --> m");
            Console.WriteLine("c. stopy --> m");
            Console.WriteLine("d. cale --> cm");
            Console.WriteLine("Jednostki masy:");
            Console.WriteLine("e. funty --> kg");
            Console.WriteLine("f. uncje --> g");
            Console.WriteLine("g. karaty --> gramy");
            Console.WriteLine("Jednostki objętości:");
            Console.WriteLine("h. galony --> l");
            Console.WriteLine("i. baryłki --> l");

            char wybor;
            double wartosc;
            Console.WriteLine("Wybierz działanie (a-i)");
            wybor = char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość:");
            wartosc = double.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 'a':
                    double dzialaniea;
                    dzialaniea = wartosc * 1.61;
                    Console.WriteLine(dzialaniea);
                    break;
                case 'b':
                    double dzialanieb;
                    dzialanieb = wartosc * 0.91;
                    Console.WriteLine(dzialanieb);
                    break;
                case 'c':
                    double dzialaniec;
                    dzialaniec = wartosc * 1.61;
                    Console.WriteLine(dzialaniec);
                    break;
                case 'd':
                    double dzialanied;
                    dzialanied = wartosc * 1.61;
                    Console.WriteLine(dzialanied);
                    break;
                case 'e':
                    double dzialaniee;
                    dzialaniee = wartosc * 1.61;
                    Console.WriteLine(dzialaniee);
                    break;
                case 'f':
                    double dzialanief;
                    dzialanief = wartosc * 1.61;
                    Console.WriteLine(dzialanief);
                    break;
                case 'g':
                    double dzialanieg;
                    dzialanieg = wartosc * 1.61;
                    Console.WriteLine(dzialanieg);
                    break;
                case 'h':
                    double dzialanieh;
                    dzialanieh = wartosc * 1.61;
                    Console.WriteLine(dzialanieh);
                    break;
                case 'i':
                    double dzialaniei;
                    dzialaniei = wartosc * 1.61;
                    Console.WriteLine(dzialaniei);
                    break;
                default:
                    Console.WriteLine("Błędna wartość.");
                    break;




            }
        }
    }
}
