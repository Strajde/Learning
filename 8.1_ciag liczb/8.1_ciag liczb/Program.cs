using System;

namespace _8._1_ciag_liczb
{
    class Program
    {
        static void srednia(int[] t, int a)
        {
            double suma = 0, srednia;

            foreach (var item in t)
                suma += item;
            srednia = suma / a;

            Console.Write("Srednia z liczb ");

            foreach(var item in t)
                Console.Write("{0} ",item);
            Console.WriteLine("wynosi {0}",srednia);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość liczb:");
            int a;

            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Błędne dane. Wprowadź raz jeszcze:");
            }

            int[] T = new int[a];
            Console.WriteLine("Wprowadź liczby:");

            for (int i = 0; i < a; i++)
            {
                while(!int.TryParse(Console.ReadLine(), out T[i]))
                    Console.WriteLine("Błędne dane. Wprowadź raz jeszcze:");
            }
            srednia(T, a);
        }
    }
}
