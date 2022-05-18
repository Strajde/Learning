using System;

namespace zad_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool DodatnieIPodzielne(int a)
            {
                if (a > 0)
                {
                    if (a % 3 == 0)
                        return true;
                }
                return false;
            }
            double srednia(int x,int y)
            {
                double sr = x / y;
                return sr;
            }
            
            
            int ile = 0,losowa;
            int suma = 0;
            int suma3 = 0;
            Random los = new Random();

            do
            {
                losowa = int.Parse(Console.ReadLine());
                suma += losowa;
                if (DodatnieIPodzielne(losowa))
                    suma3++;
                ile++;
            }
            while (losowa != 150);

            Console.WriteLine("Suma = " + suma);
            Console.WriteLine("Średnia = " + srednia(suma,ile));
            Console.WriteLine("Dodatnie, podzielne przez 3: " + suma3);
            
            

        }
    }
}
