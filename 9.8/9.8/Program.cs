using System;
using System.IO;

namespace _9._8
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream txt = new FileStream("c:\\pliki\\dane.txt",FileMode.Open, FileAccess.Read);
            StreamReader czytajTxt = new StreamReader(txt);
            FileStream bin = new FileStream("c:\\pliki\\dane.bin", FileMode.Open, FileAccess.Read);
            BinaryReader czytajBin = new BinaryReader(bin);

            Int32 sumaTxt = 0,a;
            int sumaBin = 0;
            
            string b;

            

            try
            {
                for(int i = 0; i<1000;i++)
                {
                    b = czytajTxt.ReadLine();
                    a = int.Parse(b);                    
                    sumaTxt += a;
                    a = czytajBin.ReadInt32();
                    Console.WriteLine(a);
                    sumaBin += a;
                    
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("kaszanka");               
            }
            czytajTxt.Close();
            czytajBin.Close();

            Console.WriteLine("Suma Txt: {0}", sumaTxt);
            Console.WriteLine("Suma Bin: {0}", sumaBin);
        }
    }
}
