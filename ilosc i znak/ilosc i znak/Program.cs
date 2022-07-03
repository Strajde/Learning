using System;

namespace ilosc_i_znak
{
    class Program
    {
        static void Main(string[] args)
        {
            void zadanie(char znak,int ilosc)
            {
                for (int i = 0; i < ilosc; i++)
                {
                    for (int ii = 0; ii <= i; ii++)
                    {
                        Console.Write(znak);
                    }
                    Console.WriteLine("\n");
                }
            }

            Console.WriteLine("Podaj znak: ");
            char a = char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilość: ");
            int b = int.Parse(Console.ReadLine());

            zadanie(a, b);
        }
    }
}
