using System;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź tekst: ");

            string a = Console.ReadLine();
            a = a.Replace(" ", String.Empty);
            Console.WriteLine(a);
        }
    }
}
