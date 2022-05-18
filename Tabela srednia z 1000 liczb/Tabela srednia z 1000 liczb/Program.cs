using System;

namespace Tabela_srednia_z_1000_liczb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int suma = 0;
            int sumawyswietlonych = 0;
            int iloscwyswietlonych = 0;
            double srednia;
            
            Random los = new Random();

            for (int i = 0; i < 1000; i++)
                tab[i] = los.Next(1,10000);
            foreach(var element in tab)
                suma += element;
            srednia = (double)suma / 1000;
            Console.WriteLine("Średnia: " + srednia);
            foreach (var element in tab)
                if (element > srednia)
                {
                    Console.WriteLine(element);
                    sumawyswietlonych += element;
                    iloscwyswietlonych++;
                }
            Console.WriteLine("Suma wyświetlonych: " + sumawyswietlonych);
            Console.WriteLine("Ilość wyświetlonych: " + iloscwyswietlonych);

            
        }
    }
}
