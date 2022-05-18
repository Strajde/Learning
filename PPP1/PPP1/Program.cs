using System;
using System.Diagnostics;

namespace PPP1
{
    class Program
    {
        const int C_Max = 256 * 1024 * 1024 - 1;
        static int[] Tab;
        static ulong Cnt;
        static double czas;



        static int LinSearchCnt(int Max, int Number)
        {
            for (int i = 0; i < Max; i++)
            {
                Cnt++;
                if (Tab[i] == Number) return 1;
            }
            return -1;
        }
        static int LinSearchTim(int Max, int Number)
        {

            for (int i = 0; i < Max; i++)
            {
                if (Tab[i] == Number) return 1;
            }

            return -1;
        }
        static int BinSearchCnt(int Max, int Number)
        {
            int Left = 0;
            int Right = Max - 1;
            int Middle;
            while (Left <= Right)
            {
                Middle = (Left + Right) >> 1;
                int val = Tab[Middle];
                Cnt++;
                if (val == Number) return Middle;
                else
                {
                    Cnt++;
                    if (val > Number) Right = Middle - 1;
                    else Left = Middle + 1;
                }
            }
            return -1;
        }
        static int BinSearchTim(int Max, int Number)
        {
            int Left = 0;
            int Right = Max - 1;
            int Middle;
            while (Left <= Right)
            {
                Middle = (Left + Right) >> 1;
                int val = Tab[Middle];
                if (val == Number) return Middle;
                else
                {
                    Cnt++;
                    if (val > Number) Right = Middle - 1;
                    else Left = Middle + 1;
                }
            }
            return -1;
        }
        static void LinSearchPesCnt(int Max)
        {
            Cnt = 0;
            LinSearchCnt(Max, 0);
            Console.WriteLine("LinSearchPesCnt: " + Cnt);
        }
        static void BinSearchPesCnt(int Max)
        {
            Cnt = 0;
            BinSearchCnt(Max, 0);
            Console.WriteLine("BinSearchPesCnt: " + Cnt);
        }
        static void LinSearchAvgCnt(int Max)
        {
            Cnt = 0;
            for (int i = 0; i < Max; i++)
            {
                int Number = i + 1;
                LinSearchCnt(Max, Number);

            }
            Console.WriteLine("LinSearchAvgCnt : {0}", (1.0 * Cnt) / Max);
        }
        static void BinSearchAvgCnt(int Max)
        {
            Cnt = 0;
            for (int i = 0; i < Max; i++)
            {
                int Number = i + 1;
                BinSearchCnt(Max, Number);

            }
            Console.WriteLine("BinSearchAvgCnt: {0}", (1.0 * Cnt) / Max);
        }
        static void LinSearchPesTim(int Max)
        {
            Console.WriteLine("LinSearchPesTim: ");
            for (int j = 0; j < 5; j++)
            {
                czas = 0;
                Stopwatch Stoper = new Stopwatch();
                Stoper.Start();
                LinSearchTim(Max, 0);
                Stoper.Stop();
                czas = Stoper.ElapsedMilliseconds;
                Console.Write(czas + "ms \t\t");
            }
            Console.WriteLine();
        }
        static void LinSearchAvgTim(int Max)
        {
            Console.WriteLine("LinSearchAvgTim: ");
            for (int j = 0; j < 5; j++)
            {
                czas = 0;
                Stopwatch Stoper = new Stopwatch();
                Stoper.Start();
                for (int i = 0; i < Max; i++)
                {
                    int Number = i + 1;
                    LinSearchTim(Max, Number);
                }
                Stoper.Stop();
                czas = Stoper.ElapsedMilliseconds;
                Console.Write("{0}ms \t", czas / Max);
            }
            Console.WriteLine("\n");
        }
        static void BinSearchPesTim(int Max)
        {
            Console.WriteLine("BinSearchPesTim: ");
            for (int j = 0; j < 5; j++)
            {
                czas = 0;
                Stopwatch Stoper = new Stopwatch();
                Stoper.Start();
                for (int i = 0; i < 100000; i++)
                    BinSearchTim(Max, 0);
                Stoper.Stop();
                czas = Stoper.ElapsedMilliseconds;
                Console.Write(czas / 100000 + "ms \t");
            }
            Console.WriteLine();
        }
        static void BinSearchAvgTim(int Max)
        {
            Console.WriteLine("BinSearchAvgTim: ");
            for (int j = 0; j < 5; j++)
            {
                czas = 0;
                Stopwatch Stoper = new Stopwatch();
                Stoper.Start();
                for (int i = 0; i < Max; i++)
                {
                    int Number = i + 1;
                    BinSearchTim(Max, Number);
                }
                Stoper.Stop();
                czas = Stoper.ElapsedMilliseconds;
                Console.Write("{0}ms \t", czas / Max);
            }
            Console.WriteLine();
        }


        static void Main()
        {
            Console.WriteLine("Alokacja tablicy...");
            Tab = new int[C_Max];
            for (int i = 0; i < C_Max; i++) Tab[i] = i + 1;

            Console.WriteLine("Pomiar czasów:");
            Console.WriteLine("1pomiar \t 2pomiar \t 3pomiar \t 4pomiar \t 5pomiar");
            LinSearchPesTim(Tab.Length);
            LinSearchAvgTim(100000);
            BinSearchPesTim(Tab.Length);
            BinSearchAvgTim(100000);
            Console.WriteLine("Pomiar ilości obliczeń:");
            LinSearchPesCnt(Tab.Length);
            LinSearchAvgCnt(100000);
            BinSearchPesCnt(Tab.Length);
            BinSearchAvgCnt(100000);




        }
    }
}



