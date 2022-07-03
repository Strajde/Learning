using System;

namespace switch_tydzien
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool ok;
            Console.WriteLine("Wpisz nr dnia tygodnia (np. wtorek = 2):");
            ok = int.TryParse(Console.ReadLine(), out a);

            if(ok==true)
            {
                switch(a)
                {
                    case 1: Console.WriteLine("poniedziałek"); break;
                    case 2: Console.WriteLine("wtorek"); break;
                    case 3: Console.WriteLine("środa"); break;
                    case 4: Console.WriteLine("czwartek"); break;
                    case 5: Console.WriteLine("piątek"); break;
                    case 6: Console.WriteLine("sobota"); break;
                    case 7: Console.WriteLine("niedziela"); break;
                    default: Console.WriteLine("Nie rozpędzaj się tak."); break;
                }
            }
            else
                Console.WriteLine("Podano błędna wartość.");
        }
    }
}
