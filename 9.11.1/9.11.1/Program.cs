using System;
using System.IO;

namespace _9._11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("C:\\pliki\\plik9.11.1a.txt", FileMode.Open, FileAccess.Read );
            StreamReader czyt1 = new StreamReader(fs1);
            FileStream fs2 = new FileStream("C:\\pliki\\plik9.11.1b.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter pisz1 = new StreamWriter(fs2);

            string a;

            while (!czyt1.EndOfStream)
            {
                a = czyt1.ReadLine();
                pisz1.WriteLine(a);
                a = czyt1.ReadLine();               

            }
            czyt1.Close();
            pisz1.Close();
        }
    }
}
