using System;

namespace ile_uplynelo_dni_w_roku_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,m31,m30,m28,wynik;
            bool ok;
            Console.WriteLine("Podaj nr miesiąca (np. luty -> 2):");
            ok = int.TryParse(Console.ReadLine(), out a) && a > 0 && a<=12;

            if (ok == true)
            {
              
                m31 = 31;
                m30 = 30;
                m28 = 28;
                

                switch (a)
                {
                    case 1: wynik = 0; break;
                    case 2: wynik =  m31;  break;
                    case 3: wynik = (m31 + m28);  break;
                    case 4: wynik = (2*m31 + m28);  break;
                    case 5: wynik = (2 * m31 + m28 + m30);  break;
                    case 6: wynik = (3 * m31 + m28 + m30);  break;
                    case 7: wynik = (3 * m31 + m28 + 2*m30);  break;
                    case 8: wynik = (4 * m31 + m28 + 2*m30);  break;
                    case 9: wynik = (5 * m31 + m28 + 2*m30);  break;
                    case 10: wynik = (5 * m31 + m28 + 3*m30);  break;
                    case 11: wynik = (6 * m31 + m28 + 3*m30);  break;
                    case 12: wynik = (6 * m31 + m28 + 4*m30);  break;
                    default: wynik = 999; break;
                    
                }
                Console.WriteLine("Od początku roku upłynęło " + wynik + " dni.");
            }
            else
                Console.WriteLine("Podano błędną wartość.");
        }
    }
}
