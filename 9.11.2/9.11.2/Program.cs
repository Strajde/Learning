using System;
using System.IO;

namespace _9._11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("C:\\pliki\\parzyste.txt", FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter pisz = new StreamWriter(fs1);

            Random los = new Random();
            int a;

            for (int i = 0; i < 100; i++)
            {
                do
                {
                    a = los.Next(1, 101);
                }
                while (a%2 != 0);
                pisz.WriteLine(a);
            }
            pisz.Close();
        }
    }
}
