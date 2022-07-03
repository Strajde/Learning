using System;

namespace stopien_n_macierzy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;           
            bool n_ok, wartosc_ok;
            Console.WriteLine("Podaj stopień macierzy kwadratowej (1-9) ");
            n_ok = int.TryParse(Console.ReadLine(), out n) && n >= 1 && n <= 9;
            int[,] macierz = new int[n, n];
            int[] sumax = new int[n];
            int[] sumay = new int[n];            


            for (int x = 0; x < n; x++)
                
                    for (int y = 0; y < n; y++)
                    {
                        wartosc_ok = int.TryParse(Console.ReadLine(), out macierz[x, y]);
                    sumax[x] += macierz[x, y];
                    sumay[y] += macierz[x, y];
                    }

            Console.WriteLine("\n\n");

            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    Console.Write(macierz[x, y] + "  ");
                }
                Console.WriteLine("\n");
            }

            int miny = sumay[0]; int minx = sumax[0];int wiersz = 1;int kolumna = 1;
            
            for(int i = 0; i < n; i++)
                if(minx > sumax[i])
                {
                    minx = sumax[i];
                    wiersz = i +1;
                }
            for (int i = 0; i < n; i++)
                if (miny > sumax[i])
                {
                    miny = sumax[i];
                    kolumna = i + 1;
                }

            Console.WriteLine("Wiersz z najmniejszą sumą: " + wiersz);
            Console.WriteLine("Kolumna z najmniejszą sumą: " + kolumna);




        }
    }
}
