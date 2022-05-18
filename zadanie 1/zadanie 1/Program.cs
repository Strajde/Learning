using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string a, b = "";

            Console.Write("Podaj wyraz: ");

            a = Console.ReadLine();

            for (int i = a.Length - 1; i >= 0; i--)
            {
                b += a[i];

            }

            if (a == b)
            {

                Console.Write("Wyraz jest palindromem.");

            }
            else
            {

                Console.Write("Wyraz nie jest palindromem");

            }

        }
    }
}