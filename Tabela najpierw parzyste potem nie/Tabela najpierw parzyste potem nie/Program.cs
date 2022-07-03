using System;

namespace Tabela_najpierw_parzyste_potem_nie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[30];
            Random los = new Random();

            for (int i = 0; i < 30; i++)
                tab[i] = los.Next(0, 100);
            foreach(var element in tab)
                if(element % 2 ==0)
                    Console.WriteLine(element);
            foreach(var elemenet in tab)
                if(elemenet % 2 != 0)
                    Console.WriteLine(elemenet);
        }
    }
}
