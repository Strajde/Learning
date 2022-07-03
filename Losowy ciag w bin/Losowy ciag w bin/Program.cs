using System;
using System.IO;

namespace Losowy_ciag_w_bin
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists(@"C:\pliki\dane.bin"))
                File.Delete(@"C:\pliki\dane.bin");

            
            FileStream pbin = new FileStream(@"C:\pliki\dane.bin", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter pb = new BinaryWriter(pbin);

            int[] tab = new int[200];
            Random los = new Random();

            tab[0] = los.Next(1, 10);
            for (int i = 1; i < 200; i++)
            {
                tab[i] = tab[i - 1] + los.Next(1, 10);
            }

            foreach (var item in tab)
            {
                pb.Write(item);
            }

            pb.Close();
        }
    }
}
