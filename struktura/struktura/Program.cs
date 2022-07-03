using System;

namespace struktura
{
    class Program
    {
        struct Dane
        {
            public string nazwa;
            public int metry;

        }
        static void Main(string[] args)
        {
            int max = 0;
            int suma = 0;
            string winner = "";
            Dane[] tab = new Dane[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj imię: ");
                tab[i].nazwa = Console.ReadLine();
                Console.WriteLine("Podaj długość skoku:");
                tab[i].metry = int.Parse(Console.ReadLine());
                suma += tab[i].metry;
                if (tab[i].metry > max)
                {
                    max = tab[i].metry;
                    winner = tab[i].nazwa;
                }
            }
            Console.WriteLine("Najdłuższy skok: " + max);
            Console.WriteLine("Zwycięzca: " + winner); ;
            Console.WriteLine("Suma skoków: " + suma);
            
        }
    }
}
