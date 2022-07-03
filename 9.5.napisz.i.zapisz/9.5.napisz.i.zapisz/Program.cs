using System;
using System.IO;

namespace _9._5.napisz.i.zapisz
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("c:\\pliki\\plik2.txt",FileMode.Open,FileAccess.ReadWrite);
            StreamWriter pisz = new StreamWriter(fs);
            string a;

            do
            {
                a = Console.ReadLine();
                pisz.WriteLine(a);
            }
            while (a.Length!=0);

            pisz.Close();
        }
    }
}
