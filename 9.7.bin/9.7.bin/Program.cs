using System;
using System.IO;

namespace _9._7.bin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random los = new Random();

            FileStream txt = new FileStream("c:\\pliki\\dane.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter piszTxt = new StreamWriter(txt);
            FileStream bin = new FileStream("c:\\pliki\\dane.bin", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter piszBin = new StreamWriter(bin);

            int a;

            for (int i = 0; i < 1000; i++)
            {
                a = los.Next(1, 1001);
                piszTxt.WriteLine(a);
                piszBin.WriteLine(a);
            }

            piszTxt.Close();
            piszBin.Close();
        }
    }
}
