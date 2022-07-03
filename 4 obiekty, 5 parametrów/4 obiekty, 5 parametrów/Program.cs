using System;

namespace _4_obiekty__5_parametrów
{
    class Program
    {
        struct Dom
        {
            public string kolor_elewacji, kolor_dachu, powierzchnia, ilosc_pieter, rok_budowy;
            
        }
        struct Dom2
        {
            public string kolor_elewacji2, kolor_dachu2, powierzchnia2, ilosc_pieter2, rok_budowy2;
            
           

        }
        static void Main(string[] args)
        {
            Dom[] tab = new Dom[4];
            Dom2[] tab2 = new Dom2[4];
            

            for (int i = 0; i < 4; i++)
            {
                tab2[i].kolor_elewacji2 = ("");
                tab2[i].kolor_dachu2 = ("");
                tab2[i].powierzchnia2 = ("");
                tab2[i].ilosc_pieter2 = ("");
                tab2[i].rok_budowy2 = ("");
            }

                for (int i = 0; i < 4; i++)
            {
                int rok = i + 1;
                Console.WriteLine("Dom nr " + rok + "\n");

                Console.WriteLine("Podaj kolor elewacji: ");
                tab[i].kolor_elewacji = Console.ReadLine();
                for(int ii = tab[i].kolor_elewacji.Length-1; ii>=0; ii--)
                {
                    tab2[i].kolor_elewacji2 += tab[i].kolor_elewacji[ii];
                }

                Console.WriteLine("Podaj kolor dachu: ");
                tab[i].kolor_dachu = Console.ReadLine();
                for (int ii = tab[i].kolor_dachu.Length - 1; ii >= 0; ii--)
                {
                    tab2[i].kolor_dachu2 += tab[i].kolor_dachu[ii];
                }

                Console.WriteLine("Podaj powierzchnię domu(m.kwadratowe): ");
                tab[i].powierzchnia = Console.ReadLine();
                for (int ii = tab[i].powierzchnia.Length - 1; ii >= 0; ii--)
                {
                    tab2[i].powierzchnia2 += tab[i].powierzchnia[ii];
                }

                Console.WriteLine("Podaj ilość pięter: ");
                tab[i].ilosc_pieter = Console.ReadLine();
                for (int ii = tab[i].ilosc_pieter.Length - 1; ii >= 0; ii--)
                {
                    tab2[i].ilosc_pieter2 += tab[i].ilosc_pieter[ii];
                }

                Console.WriteLine("Podaj rok budowy: ");
                tab[i].rok_budowy = Console.ReadLine();
                for (int ii = tab[i].rok_budowy.Length - 1; ii >= 0; ii--)
                {
                    tab2[i].rok_budowy2 += tab[i].rok_budowy[ii];
                }

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

            Console.WriteLine("Tekst parametrów w odwrotnej kolejności: \n");

            for (int i = 0; i < 4; i++)
            {
                int rok = i + 1;
                Console.WriteLine("Dom nr " + rok + "\n");
                Console.WriteLine("Rok budowy: " + tab2[i].rok_budowy2);
                Console.WriteLine("Ilość pięter: " + tab2[i].ilosc_pieter2);
                Console.WriteLine("Powierzchnia domu(m. kwadratowe) :" + tab2[i].powierzchnia2);
                Console.WriteLine("Kolor dachu: " + tab2[i].kolor_dachu2);
                Console.WriteLine("Kolor elewacji: " + tab2[i].kolor_elewacji2 + "\n");
            }



        }
    }
}
