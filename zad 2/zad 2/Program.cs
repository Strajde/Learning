using System;

namespace zad_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int losowany; int a; 
            bool ok = int.TryParse(Console.ReadLine(),out a);
            int sumadodatnich = 0;
            int sumaujemnych = 0;
            int max = 0;
            int min = 0;
            Random los = new Random();

            if (ok)
            {
                for (int i = 0; i < a; i++)
                {
                    losowany = los.Next(-100, 101);
                    if (losowany > max)
                        max = losowany;
                    else if (losowany < min)
                        min = losowany;
                     if(losowany < 0)
                        sumaujemnych++;
                    else if (losowany > 0)
                        sumadodatnich++;
                    Console.WriteLine(losowany);

                }
                Console.WriteLine("Stosunek ujemne/dodatnie :" + sumaujemnych + "/" + sumadodatnich);
                Console.WriteLine("Max.: " + max);
                Console.WriteLine("Min." + min);
            }
            else
                Console.WriteLine("Błędna warość.");
        }
    }
}
