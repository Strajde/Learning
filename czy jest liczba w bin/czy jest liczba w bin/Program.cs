using System;
using System.IO;

namespace czy_jest_liczba_w_bin
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());

            FileStream pbin = new FileStream(@"C:\pliki\dane.bin", FileMode.Open, FileAccess.Read);
            BinaryReader pb = new BinaryReader(pbin);

            int[] tab = new int[200];
            bool czy = false;

            for (int i = 0; i < 200; i++)
            {
                tab[i] = pb.ReadInt32();
                if (tab[i] == a)
                    czy = true;
            }
            if(czy)
                Console.WriteLine("Jest.");
            else
                Console.WriteLine("Nie ma.");
            pb.Close();
        }
       
    }
}
