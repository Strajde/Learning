using System;
using System.IO;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("C:\\pliki\\dan.txt", FileMode.Open, FileAccess.Read);
            StreamReader czyt1 = new StreamReader(fs1);
            
            
            while (!czyt1.EndOfStream)
            {
                string b = "";
                string a = czyt1.ReadLine();                

                for (int i = a.Length - 1; i >= 0; i--)
                {
                    b += a[i];

                }

                if (a == b)
                {

                    Console.WriteLine(a);

                }
                
                
               
            }
            czyt1.Close();
        }
    }
}
