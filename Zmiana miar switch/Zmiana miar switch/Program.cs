using System;

namespace Zmiana_miar_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            bool znak_a, znak_b, wartoscA;
            char znakA, znakB;
            Console.WriteLine("Co będziemy przeliczć? \n \n a. jednostki długości \n b. jednostki masy \n c. jednostki objętości ");
            znak_a = char.TryParse(Console.ReadLine(), out znakA);

            switch (znakA)
            {
                case 'a':
                    Console.WriteLine("Przelicznie długości: \n \n a. mile na kilometry (przelicznik 1.61 kilometra) \n b. jardy na metry (przelicznik 0,9144 metra) \n c. stopy na metry (przelicznik 0,3048 metra) \n d. cale na centymetry (przelicznik 2,54 centymetra)");
                    znak_b = char.TryParse(Console.ReadLine(), out znakB);
                    switch(znakB)
                    {
                        case 'a':
                            Console.WriteLine("Podaj ilość mil: ");
                            wartoscA = double.TryParse(Console.ReadLine(), out a);
                            if(wartoscA==true)
                            {
                                b = a * 1.61;
                                Console.WriteLine("Wynik: " + b + " kilometrów");
                            }
                            else
                                Console.WriteLine("Podano błędną wartość.");
                            break;
                        case 'b':
                            Console.WriteLine("Podaj ilość jardów: ");
                            wartoscA = double.TryParse(Console.ReadLine(), out a);
                            if (wartoscA == true)
                            {
                                b = a * 0.9144;
                                Console.WriteLine("Wynik: " + b + " metrów");
                            }
                            else
                                Console.WriteLine("Podano błędną wartość.");
                            break;
                        case 'c':
                            Console.WriteLine("Podaj ilość stóp: ");
                            wartoscA = double.TryParse(Console.ReadLine(), out a);
                            if (wartoscA == true)
                            {
                                b = a * 0.3048;
                                Console.WriteLine("Wynik: " + b + " metrów");
                            }
                            else
                                Console.WriteLine("Podano błędną wartość.");
                            break;
                        case 'd':
                            Console.WriteLine("Podaj ilość cali: ");
                            wartoscA = double.TryParse(Console.ReadLine(), out a);
                            if (wartoscA == true)
                            {
                                b = a * 2.54;
                                Console.WriteLine("Wynik: " + b + " centymetrów");
                            }
                            else
                                Console.WriteLine("Podano błędną wartość.");
                            break;
                        default: Console.WriteLine("Podano błędną wartość."); break;
                    }
                    break;

                case 'b':
                    Console.WriteLine("Przelicznie masy : \n \n a. funty na kilogramy (przelicznik 0,45359237 kilograma) \n b. uncje na gramy (przelicznik 28,3495231 grama) \n c. karaty na gramy (przelicznik 0,2 grama)");
                    znak_b = char.TryParse(Console.ReadLine(), out znakB);
                    switch(znakB)
                    {
                        case 'a':
                            Console.WriteLine("Podaj ilość funtów: ");
                            wartoscA = double.TryParse(Console.ReadLine(), out a);
                            if (wartoscA == true)
                            {
                                b = a * 0.45359237;
                                Console.WriteLine("Wynik: " + b + " kilogramów");
                            }
                            else
                                Console.WriteLine("Podano błędną wartość.");
                            break;
                        case 'b':
                            Console.WriteLine("Podaj ilość uncji: ");
                            wartoscA = double.TryParse(Console.ReadLine(), out a);
                            if (wartoscA == true)
                            {
                                b = a * 28.3495231;
                                Console.WriteLine("Wynik: " + b + " gramów");
                            }
                            else
                                Console.WriteLine("Podano błędną wartość.");
                            break;
                        case 'c':
                            Console.WriteLine("Podaj ilość karatów: ");
                            wartoscA = double.TryParse(Console.ReadLine(), out a);
                            if (wartoscA == true)
                            {
                                b = a * 0.2;
                                Console.WriteLine("Wynik: " + b + " gramów");
                            }
                            else
                                Console.WriteLine("Podano błędną wartość.");
                            break;
                        default: Console.WriteLine("Podano błędną wartość."); break;

                    }
                    break;
                case 'c':
                    Console.WriteLine("Przelicznie objętości : \n \n a. galony na litry (przelicznik 4,54609 litra) \n b. baryłki na litry (przelicznik 158,987295 litra)");
                    znak_b = char.TryParse(Console.ReadLine(), out znakB);
                    switch (znakB)
                    {
                        case 'a':
                            Console.WriteLine("Podaj ilość galonów: ");
                            wartoscA = double.TryParse(Console.ReadLine(), out a);
                            if (wartoscA == true)
                            {
                                b = a * 4.54609;
                                Console.WriteLine("Wynik: " + b + " litrów");
                            }
                            else
                                Console.WriteLine("Podano błędną wartość.");
                            break;
                        case 'b':
                            Console.WriteLine("Podaj ilość baryłek: ");
                            wartoscA = double.TryParse(Console.ReadLine(), out a);
                            if (wartoscA == true)
                            {
                                b = a * 158.987295;

                                Console.WriteLine("Wynik: " + b + " litrów");
                            }
                            else
                                Console.WriteLine("Podano błędną wartość.");
                            break;
                        default: Console.WriteLine("Podano błędną wartość."); break;

                    }
                    break;


                default: Console.WriteLine("Podano błędną wartość."); break;
            }
        }
    }
}
