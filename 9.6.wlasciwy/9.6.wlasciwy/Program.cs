using System;
using System.IO;

namespace _9._6.wlasciwy
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("c:\\pliki\\plik3_1.txt", FileMode.Open, FileAccess.Read);
            StreamReader czytaj1 = new StreamReader(fs1);
            FileStream fs2 = new FileStream("c:\\pliki\\plik3_2.txt", FileMode.Open, FileAccess.Read);
            StreamReader czytaj2 = new StreamReader(fs2);

            FileStream fs3 = new FileStream("c:\\pliki\\plik3_3.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter pisz1 = new StreamWriter(fs3);

            string a;

            while (!czytaj1.EndOfStream && !czytaj2.EndOfStream)
            {
                a = czytaj1.ReadLine();
                pisz1.WriteLine(a);
                Console.WriteLine(a);
                a = czytaj2.ReadLine();
                pisz1.WriteLine(a);
                Console.WriteLine(a);
            }
            czytaj1.Close();
            czytaj2.Close();
            pisz1.Close();
        }
    }
}
