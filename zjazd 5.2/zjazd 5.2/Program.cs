using System;
using System.IO;

namespace zjazd_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nazwa = Console.ReadLine();

            if (!Directory.Exists(@nazwa))
            {
                Console.WriteLine("Nie ma.");
            }
            else
            {
                string[] b = Directory.GetFiles(nazwa);
            }
        }
    }
}
