using System;

namespace iledni
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Wpisz nr miesiąca.");
            a = double.Parse(Console.ReadLine());

            switch (a)
            {
           
                    
                case 1:
                    Console.WriteLine("0");
                    break;
                case 2:
                    Console.WriteLine("31");
                    break;
                case 3:
                    Console.WriteLine("59");
                    break;
                case 4:
                    Console.WriteLine("90");
                    break;
                case 5:
                    Console.WriteLine("120");
                    break;
                case 6:
                    Console.WriteLine("151");
                    break;
                case 7:
                    Console.WriteLine("181");
                    break;
                case 8:
                    Console.WriteLine("212");
                    break;
                case 9:
                    Console.WriteLine("243");
                    break;
                case 10:
                    Console.WriteLine("273");
                    break;
                case 11:
                    Console.WriteLine("304");
                    break;
                case 12:
                    Console.WriteLine("334");
                    break;
                default:
                    Console.WriteLine("Błędna wartość.");
                    break;




            } }
    }
}
