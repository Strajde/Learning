using System;

namespace ile_razy_pojawila_sie
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] generator = new int[10000];
            int[] suma = new int[51];
            Random los = new Random();

            for (int i = 0; i < 10000; i++)
            {
                generator[i] = los.Next(1, 50);
                for (int ii = 0; i < 50; i++)
                    if (generator[i] == ii)
                        suma[ii]++;
            }
            for(int i = 0; i<50; i++)
                Console.WriteLine(suma[i]);
        }
    }
}
