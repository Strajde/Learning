using System;

namespace biletPKS
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            double cena;
            bool odleglosc;
            Console.WriteLine("Podaj długość trasy w km. :");
            odleglosc = int.TryParse(Console.ReadLine(), out k);

            if(odleglosc)
            {
                if(k >= 0 && k <= 10)
                {
                    cena = 2;
                    Console.WriteLine("Cena biletu: " + cena + " zł.");
                }

                else if(k >= 11 && k<= 30)
                {
                    cena = 1 + 0.1 * k;
                    Console.WriteLine("Cena biletu: " + cena + " zł.");
                }

                else if(k > 30)
                {
                    cena = 1 + 0.08 * k;
                    Console.WriteLine("Cena biletu: " + cena + " zł.");
                }
            }
            else 
            {
                cena = -1;
                Console.WriteLine("Cena biletu: " + cena + " zł.");
            }
        }
    }
}
