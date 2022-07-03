using System;

namespace tabela_suma_wartosci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];
            int suma = 0;
            for (int i = 0; i < 10; i++)
                tab[i] = int.Parse(Console.ReadLine());
            foreach (var element in tab)
                suma += element;
            Console.WriteLine("Suma: " + suma);
        }
    }
}
