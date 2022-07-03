using System;
using System.IO;

namespace pliki
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[10];
            Random los = new Random();

            for (int i = 0; i < 10; i++)
            {
                t[i] = los.Next(10, 30);
                Console.Write(t[i] + " ");
            }
            FileStream zapis = new FileStream(@"C:\pliki\dane.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter dozapisywania = new StreamWriter(zapis);

            for(int i = 0; i<10;i++)
            {
                dozapisywania.WriteLine(t[i]);
            }
            dozapisywania.Close();
        }
    }
}
