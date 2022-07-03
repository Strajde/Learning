using System;

namespace net
{
    class Program
    {
        static void Main(string[] args)
        {
            Random los = new Random(Guid.NewGuid().GetHashCode()) ;
            int wylosowana = los.Next(1, 11);

            Console.WriteLine("Maszyna losująca ruszyła.");
            Console.WriteLine("Została wylosowana liczba od 1 do 10.");
            Console.WriteLine("Masz 3 próby. Jaki jest Twój typ?");
            // Console.WriteLine(wylosowana);

            string wprowadzone;
            int typowana, szanse = 2;
            bool czyTrafiony = false;

            for (int x = 0; x < 3; x++, szanse--)
            {
                wprowadzone = Console.ReadLine();
                czyTrafiony = int.TryParse(wprowadzone,out typowana);

                if (czyTrafiony == false)
                {
                    Console.WriteLine("Wprowadzono błedną warość");
                    Console.WriteLine("Szanse: " + szanse);
                    if (szanse == 0)
                        Console.WriteLine("Niestety, przekroczyłeś limit szans. Przegrałeś.");
                    continue;
                }


                if (wylosowana == typowana)
                {
                    Console.WriteLine("Brawo, wylosowana liczba to " + typowana + "!");
                    break;
                }
                else
                    Console.WriteLine("Niestety nie trafiłeś.");
                
                Console.WriteLine("Szanse: " + szanse);

                if (szanse==0)
                    Console.WriteLine("Niestety, przekroczyłeś limit szans. Przegrałeś.");
            }


        }
    }
}
