using System;

namespace kalkulatoe_char
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, wynik;
            char znak;
            bool a_ok,b_ok, znak_ok;
            Console.WriteLine("Podaj pierwszą liczbę działania: ");
            a_ok = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Podaj drugą liczbę działania: ");
            b_ok = double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Jakie działanie chcesz wykonać? \n + -> dodawanie \n - -> odejmowanie \n / -> dzielenie \n * -> mnożenie" );
            znak_ok = char.TryParse(Console.ReadLine(), out znak);

            if(a_ok==true && b_ok==true && znak_ok==true )
            {
                switch(znak)
                {
                    case '+': wynik = a + b; Console.WriteLine("Wynik: " + wynik);break;
                    case '-': wynik = a - b; Console.WriteLine("Wynik: " + wynik); break;
                    case '/':
                        if (b != 0)
                        {
                            wynik = a / b;
                            Console.WriteLine("Wynik: " + wynik);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Próba dzielenia przez 0.");
                            break;
                        }
                    case '*': wynik = a * b; Console.WriteLine("Wynik: " + wynik); break;
                    default: Console.WriteLine("Błędny znak działania."); break ;


                }
            }
            else
                Console.WriteLine("Wprowadzono błędne dane.");

        }
    }
}
