using System;
using System.Numerics;
using System.Diagnostics;

namespace BigPrime
{
    class Program
    {
        static ulong Cnt;
        static double czas;
        static BigInteger[] Tab = new BigInteger[] { 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399};

       static bool IsPrime(BigInteger Number)
        {
            if (Number < 2) return false;
            else if (Number < 4) return true;
            else if (Number % 2 == 0) return false;
            else for (BigInteger u = 3; u < Number / 2; u += 2)
                    if (Number % u == 0) return false;
            return true;

        }
        static bool IsPrimeXL(BigInteger Number)
        {
            if (Number < 2) return false;
            else if (Number < 4) return true;
            else if (Number % 2 == 0) return false;
            else
            {
                for (BigInteger u = 3; u * u <= Number; u += 2)
                {
                    if (Number % u == 0) return false;
                }
            }
            return true;
        }
        
        static bool IsPrimeCnt(BigInteger Number)
        {
            Cnt = 0;
            if (Number < 2) return false;
            else if (Number < 4) return true;
            Cnt++;            
            if (Number % 2 == 0) return false;
            else for (BigInteger u = 3; u < Number / 2; u += 2)
                {
                    Cnt++;
                    if (Number % u == 0) return false;
                }
            Console.Write("Obliczenia przykładowe: " + Cnt + "\t");
            return true;
            

        }
        static bool IsPrimeTim(BigInteger Number)
        {
            
                Stopwatch Stoper = new Stopwatch();
                Stoper.Start();
                if (Number < 2) return false;
                else if (Number < 4) return true;
                else if (Number % 2 == 0) return false;
                else for (BigInteger u = 3; u < Number / 2; u += 2)
                        if (Number % u == 0) return false;
                Stoper.Stop();
                czas = Stoper.ElapsedMilliseconds;
                Console.Write("Czas przykładowy: " + czas + "ms" + "\t");
            
                return true;
            
            

        }
        static bool IsPrimeXLCnt(BigInteger Number)
        {
            Cnt = 0;
            if (Number < 2) return false;
            else if (Number < 4) return true;
            Cnt++;
            if (Number % 2 == 0) return false;
            else
            {
                for (BigInteger u = 3; u * u <= Number; u += 2)
                {
                    Cnt++;
                    if (Number % u == 0) return false;
                }
            }
            Console.Write("Obliczenia ulepszone: " + Cnt + "\t");
            return true;
        }
        static bool IsPrimeXLTim(BigInteger Number)
        {
            
                Stopwatch Stoper = new Stopwatch();
                Stoper.Start();
                if (Number < 2) return false;
                else if (Number < 4) return true;
                else if (Number % 2 == 0) return false;
                else
                {
                    for (BigInteger u = 3; u * u <= Number; u += 2)
                    {
                        if (Number % u == 0) return false;
                    }
                }
                Stoper.Stop();
                czas = Stoper.ElapsedMilliseconds;
                Console.Write("Czas ulepszony: " + czas + "ms" + "\t");
            
            return true;
        }

        static void Main(string[] args)
        {
            foreach (BigInteger a in Tab)
            {
                Console.WriteLine("Wyniki dla: " + a);
                Console.WriteLine(IsPrimeCnt(a));
                Console.WriteLine(IsPrimeXLCnt(a));
                Console.WriteLine(IsPrimeTim(a));
                Console.WriteLine(IsPrimeXLTim(a));
                Console.WriteLine();
            }

        }
    }
}
