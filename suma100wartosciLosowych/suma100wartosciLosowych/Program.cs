using System;

namespace suma100wartosciLosowych
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int suma = 0;
            Random los = new Random();

            for(int i = 0;i<1000;i++)
            {
                int zmienna = los.Next(1, 50);   // tab[i] = los.Next(1,50)
                tab[i] = zmienna;
                
            }
            foreach (var element in tab)
                suma += element;
            Console.WriteLine("Suma: " + suma);
           
        }
    }
}
