using System;

namespace CzyPierwszaFunkcja
{
    class Program
    {
        static bool Czypierwsza(int a)
        {
            for (int i = 2; i * i < a; i++)
                if (a % i == 0)
                    return false;
            return true;
                

            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Czypierwsza(4)); 
        }
    }
}
