using System;
using System.IO;

namespace _9._4.parsuj
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fs = new FileStream("C:\\pliki\\plik.txt", FileMode.Open, FileAccess.Read);
                StreamReader czytaj = new StreamReader(fs);

                int suma = 0, x;

                string a;

                while (!czytaj.EndOfStream)
                {
                    try
                    {
                        a = czytaj.ReadLine();
                        x = int.Parse(a);

                        suma += x;
                    }
                    catch (FormatException)
                    { Console.WriteLine("*"); }


                }
                czytaj.Close();
                Console.WriteLine(suma);
            }
            catch (FileNotFoundException)
            { Console.WriteLine("Brak pliku."); }
        }
    }
}
