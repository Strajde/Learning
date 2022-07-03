using System;

namespace Cwiczonka_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, NWD;

            Console.WriteLine("Podaj pierwszą liczbę");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            b = int.Parse(Console.ReadLine());

            if (b != 0)
            {
                while (a % b != 0)
               
                {
                    //a = b;
                    int d;                                                                      // wynik dzielenia
                    int e = a;                                                                  // zmienna pomocnicza
                    for (d = 0; e > 0; d++){ e = e - b; }                                       //dzielenie bez operacji dzielenia
                    int c = a % b;                                                              //wylicznie reszty z dzielenia
                    if (a > b){Console.WriteLine(a + " : " + b + " = " + d + " reszta: " + c);} // jeżeli pierwsza liczba jest większa od drugiej pisze wiersz operacji
                    a = b;                                                                      //zastąpienie starych zmiennych nowymi do następnej operacji
                    b = c;
                }
                NWD = b;
                Console.WriteLine();
                Console.WriteLine( "Największym wspólnym dzielnikiem jest "+NWD);
            }
            else
                Console.WriteLine("Próba dzielenia przez 0.");

        }
    }
}
