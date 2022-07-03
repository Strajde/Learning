using System;

namespace Agd_raty
{
    class Program
    {
        static void Main(string[] args)
        {
            double wartosc, raty, rata;
            bool wartosc_ok, raty_ok;
            Console.WriteLine("Podaj wartość produktu (od 100zł. do 10 000zł.):");
            wartosc_ok = double.TryParse(Console.ReadLine(), out wartosc) && wartosc >= 100 && wartosc <= 10000;
            Console.WriteLine("Podaj ilość rat (od 6 do 48): ");
            raty_ok = double.TryParse(Console.ReadLine(), out raty) && raty >= 6 && raty <= 48;

            if(wartosc_ok && raty_ok)
            {
                if(raty >= 6 && raty <= 12)
                {
                    rata = (wartosc * 1.025) / raty;
                }
                else if(raty >=13 && raty <= 24)
                {
                    rata = (wartosc * 1.05) / raty;
                }
                else
                {
                    rata = (wartosc * 1.1) / raty;
                }
                Console.WriteLine("Pojedyńcza rata wyniesie: " + rata + "zł.");
            }
            else if(wartosc_ok == false && raty_ok==false)
                Console.WriteLine("Podano błędna wartość produktu i błędną ilość rat.");
            else if(wartosc_ok==false)
                Console.WriteLine("Podano błędna wartość produktu.");
            else if(raty_ok==false)
                Console.WriteLine("Podano błędną liczbę rat.");
        }
    }
}
