using System;
using System.IO;
namespace _9._6.pliki._2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("c:\\pliki\\plik3_1.txt" ,FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter pisz1 = new StreamWriter(fs1);
            FileStream fs2 = new FileStream("c:\\pliki\\plik3_2.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter pisz2 = new StreamWriter(fs2);

            int a = 0;
            string slowo;

            do
            {
                if (a % 2 == 0)
                {
                    slowo = Console.ReadLine();
                    pisz1.WriteLine(slowo);
                    a++;
                }
                else
                {
                    slowo = Console.ReadLine();
                    pisz2.WriteLine(slowo);
                    a++;
                }
            }
            while (slowo.Length != 0);

            pisz1.Close();
            pisz2.Close();
        }
    }
}
