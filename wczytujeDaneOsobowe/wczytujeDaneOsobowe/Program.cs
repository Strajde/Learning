using System;

namespace wczytujeDaneOsobowe
{
    class Program
    {
        public struct Dane
        {
            public string imie, nazwisko, wiek, adres, pesel;
        }

        static Dane DoWprowadzania()
        {
            Dane a;
            Console.Write("Wprowadź imię: ");
            a.imie = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Wprowadź nazwisko: ");
            a.nazwisko = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Wprowadź wiek: ");
            a.wiek = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Wprowadź adres: ");
            a.adres = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Wprowadź pesel: ");
            a.pesel = (Console.ReadLine());
            Console.WriteLine();
            return a;
        }

        static void Main(string[] args)
        {
            Dane a = DoWprowadzania();
        }
    }
}
