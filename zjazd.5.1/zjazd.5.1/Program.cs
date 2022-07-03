using System;
using System.IO;

namespace zjazd._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("c:\\pliki\\lista.txt", FileMode.Open, FileAccess.Read);
            StreamReader czytaj = new StreamReader(fs);

            string a;

            while (!czytaj.EndOfStream)
            {
                a = czytaj.ReadLine();
                a = a.ToLower();

                if (!a.Contains("c:\\"))
                {
                    a = "c:\\" + a;

                    Directory.CreateDirectory(a);
                }
            }
            czytaj.Close();
        }
    }
}
