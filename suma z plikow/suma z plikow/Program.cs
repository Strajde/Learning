using System;
using System.IO;

namespace suma_z_plikow
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream ptxt = new FileStream(@"C:\pliki\dane.txt", FileMode.Open, FileAccess.Read);
            FileStream pbin = new FileStream(@"C:\pliki\dane.bin", FileMode.Open, FileAccess.Read);
            StreamReader pt = new StreamReader(ptxt);
            BinaryReader pb = new BinaryReader(pbin);

            Int32[] tab1 = new Int32[1000];
            Int32[] tab2 = new Int32[1000];
            int sumTxt = 0; 
            int sumBin = 0;
            string l;

            for (int i = 0; i < 1000; i++)
            {
                l = pt.ReadLine();
                tab1[i] = int.Parse(l);
                sumTxt += tab1[i];
                tab2[i] = pb.ReadInt32();
                sumBin += tab2[i];
            }

            Console.WriteLine("Txt: " + sumTxt);
            Console.WriteLine("Bin: " + sumBin);

            pt.Close();
            pb.Close();
        }
    }
}
