using System;
using System.IO;

namespace _9._3.odczyt
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:\pliki\plik.txt", FileMode.Open,FileAccess.Read );
            StreamReader czytaj = new StreamReader(fs);

            while (!czytaj.EndOfStream)
            {               
                string a = czytaj.ReadLine();
                Console.WriteLine(a);
            }
            czytaj.Close();
        }
    }
}
