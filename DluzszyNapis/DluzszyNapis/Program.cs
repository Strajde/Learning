using System;

namespace DluzszyNapis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string a, b;
            Console.WriteLine("Wprowadź pierwszy wyraz");
            a = Console.ReadLine();
            Console.WriteLine("Wprowadź pierwszy wyraz");
            b = Console.ReadLine();

            if(a.Length > b.Length)
                Console.WriteLine("Dłuższy wyraz to: " + a);
            else if (b.Length > a.Length)
                Console.WriteLine("Dłuższy wyraz to: " + b);
            else
                Console.WriteLine("Wyrazy są równej długości.");
        }
    }
}
