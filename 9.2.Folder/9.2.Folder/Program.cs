using System;
using System.IO;


namespace _9._2.Folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random los = new Random();
            int[] tab = new int[10];

            FileStream fs = new FileStream("c:\\pliki\\plik.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter pisz = new StreamWriter(fs);

            for (int i = 0; i < 10; i++)
            {
                tab[i] = los.Next(1, 11);
                pisz.WriteLine(tab[i]);
            }
            pisz.Close();
        }
    }
}
