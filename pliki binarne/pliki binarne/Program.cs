using System;
using System.IO;

namespace pliki_binarne
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream ptxt = new FileStream(@"C:\pliki\dane.txt", FileMode.OpenOrCreate, FileAccess.Write);
            FileStream pbin = new FileStream(@"C:\pliki\dane.bin", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter pt = new StreamWriter(ptxt);
            BinaryWriter pb = new BinaryWriter(pbin);

            int[] tab = new int[1000];

            Random los = new Random();

            for (int i = 0; i < 1000; i++)
            {
                tab[i] = los.Next(10, 1000);
            }
            foreach (var item in tab)
            {
                pt.WriteLine(item);
                pb.Write((int)item);
            }
            pt.Close();
            pb.Close();
        }
    }
}
