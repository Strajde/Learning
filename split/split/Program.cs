using System;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string a = Console.ReadLine();
                int suma = 0, x;
                string[] tab = a.Split(" ");

                for (int i = 0; i < tab.Length; i++)
                {
                    x = int.Parse(tab[i]);
                    suma += x;
                }
                Console.WriteLine(suma);
            }
        }
    }
}
