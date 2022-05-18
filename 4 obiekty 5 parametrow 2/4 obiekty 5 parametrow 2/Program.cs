using System;

namespace _4_obiekty_5_parametrow_2
{
    class Program
    {
        struct Dom
        {
            public string kolor_elewacji, kolor_dachu;
            public int powierzchnia, ilosc_pieter, rok_budowy;

        }
        static void Main(string[] args)
        {
            Dom[] tab = new Dom[4];

            for (int i = 0; i < 4; i++)
            {
                int rok = i + 1;
                Console.WriteLine("Dom nr " + rok + "\n");

                Console.WriteLine("Podaj kolor elewacji: ");
                tab[i].kolor_elewacji = Console.ReadLine();

                Console.WriteLine("Podaj kolor dachu: ");
                tab[i].kolor_dachu = Console.ReadLine();

                Console.WriteLine("Podaj powierzchnię domu(m.kwadratowe): ");
                tab[i].powierzchnia = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj ilość pięter: ");
                tab[i].ilosc_pieter = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj rok budowy: ");
                tab[i].rok_budowy = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");


            }
            Console.WriteLine("Parametry w odwrotnej kolejności: \n");

            for (int i = 0; i < 4; i++)
            {
                int rok = i + 1;
                Console.WriteLine("Dom nr " + rok + "\n");
                Console.WriteLine("Rok budowy: " + tab[i].rok_budowy);
                Console.WriteLine("Ilość pięter: " + tab[i].ilosc_pieter);
                Console.WriteLine("Powierzchnia domu(m. kwadratowe) :" + tab[i].powierzchnia);
                Console.WriteLine("Kolor dachu: " + tab[i].kolor_dachu);
                Console.WriteLine("Kolor elewacji: " + tab[i].kolor_elewacji + "\n");
            }
        }
    }
}
