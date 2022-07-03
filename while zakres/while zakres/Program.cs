using System;

namespace while_zakres
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,suma;
            suma = 0;
            bool liczba;

            do
            {
                Console.WriteLine("Wprowadź liczbę z zakresu -100 do 100:");
                liczba = int.TryParse(Console.ReadLine(), out i);
                suma = suma + i;


            }
            while (i >= -100 && i <= 100);

            Console.WriteLine("Suma wprowadzonych liczb: " + suma);


        }
    }
}
