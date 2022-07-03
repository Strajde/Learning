using System;
using System.Diagnostics;

namespace Projekt3_sort
{
    class Program
    {
        static Random los = new Random(Guid.NewGuid().GetHashCode());
        static uint wielkosc = 70000;
        static int[] tab = new int[wielkosc];

        static void InsertionSort(int[] t)
        {
            for (uint i = 1; i < t.Length; i++)
            {
                uint j = i;
                int Buf = t[j];
                while ((j > 0) && (t[j - 1] > Buf))
                {
                    t[j] = t[j - 1];
                    j--;
                }
                t[j] = Buf;
            }
        }

        static void SelectionSort(int[] t)
        {
            uint k;
            for (uint i = 0; i < (t.Length - 1); i++)
            {
                int Buf = t[i];
                k = i;

                for (uint j = i + 1; j < t.Length; j++)
                    if (t[j] < Buf)
                    {
                        k = j;
                        Buf = t[j];
                    }
                t[k] = t[i];
                t[i] = Buf;

            }
        }

        static void CoctailSort(int[] t)
        {
            int Left = 1, Right = t.Length - 1, k = t.Length - 1;
            do
            {
                for (int j = Right; j >= Left; j--)
                    if (t[j - 1] > t[j])
                    {
                        int Buf = t[j - 1]; t[j - 1] = t[j]; t[j] = Buf;
                        k = j;
                    }
                Left = k + 1;
                for (int j = Left; j <= Right; j++)
                    if (t[j - 1] > t[j])
                    {
                        int Buf = t[j - 1]; t[j - 1] = t[j]; t[j] = Buf;
                        k = j;
                    }
                Right = k - 1;
            }
            while (Left <= Right);
        }

        static void Heapify(int[] t, uint left, uint right)
        {
            uint i = left,
                 j = 2 * i + 1;
            int buf = t[i];
            while (j <= right)
            {
                if (j < right)
                    if (t[j] < t[j + 1]) j++;
                if (buf >= t[j]) break;
                t[i] = t[j];
                i = j;
                j = 2 * i + 1;
            }
            t[i] = buf;
        }

        static void HeapSort(int[] t)
        {
            uint left = ((uint)t.Length / 2),
                right = (uint)t.Length - 1;
            while (left > 0)
            {
                left--;
                Heapify(t, left, right);
            }
            while (right > 0)
            {
                int buf = t[left];
                t[left] = t[right];
                t[right] = buf;
                right--;
                Heapify(t, left, right);
            }
        }

        static void GenerateRandomArray(int[] t)
        {
            for (int i = 0; i < tab.Length; i++)
                tab[i] = los.Next(tab.Length);
        }
        static void GenerateIncreasingArray(int[] t)
        {
            for (int i = 0; i < tab.Length; i++)
                tab[i] = i;
        }
        static void GenerateDecreasingArray(int[] t)
        {
            for (int i = 0; i < tab.Length; i++)
                tab[i] = tab.Length - i - 1;
        }
        static void GenerateConstantArray(int[] t)
        {
            for (int i = 0; i < tab.Length; i++)
                tab[i] = 9;
        }
        static void GenerateVArray(int[] t)
        {
            int middle = tab.Length / 2;
            for (int i = 0; i < tab.Length; i++)
                if (i < middle)
                    tab[i] = middle - i - 1;
                else
                    tab[i] = i - middle;
        }

        static void Main(string[] args)
        {
            Stopwatch Stoper = new Stopwatch();

            Console.WriteLine("Insertion sort: ");
            GenerateRandomArray(tab);                                               
            Stoper.Start();
            InsertionSort(tab);
            Stoper.Stop();                
            Console.WriteLine(Stoper.ElapsedMilliseconds);                     
            Stoper.Reset();

            GenerateIncreasingArray(tab);            
            Stoper.Start();
            InsertionSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateDecreasingArray(tab);
            Stoper.Start();
            InsertionSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateConstantArray(tab);
            Stoper.Start();
            InsertionSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateVArray(tab);
            Stoper.Start();
            InsertionSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            Console.WriteLine("Selection sort: ");
            GenerateRandomArray(tab);
            Stoper.Start();
            SelectionSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateIncreasingArray(tab);
            Stoper.Start();
            SelectionSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateDecreasingArray(tab);
            Stoper.Start();
            SelectionSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateConstantArray(tab);
            Stoper.Start();
            SelectionSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateVArray(tab);
            Stoper.Start();
            SelectionSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            Console.WriteLine("Coctail sort: ");
            GenerateRandomArray(tab);
            Stoper.Start();
            CoctailSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateIncreasingArray(tab);
            Stoper.Start();
            CoctailSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateDecreasingArray(tab);
            Stoper.Start();
            CoctailSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateConstantArray(tab);
            Stoper.Start();
            CoctailSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateVArray(tab);
            Stoper.Start();
            CoctailSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            Console.WriteLine("Heap sort: ");
            GenerateRandomArray(tab);
            Stoper.Start();
            HeapSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateIncreasingArray(tab);
            Stoper.Start();
            HeapSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateDecreasingArray(tab);
            Stoper.Start();
            HeapSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateConstantArray(tab);
            Stoper.Start();
            HeapSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();

            GenerateVArray(tab);
            Stoper.Start();
            HeapSort(tab);
            Stoper.Stop();
            Console.WriteLine(Stoper.ElapsedMilliseconds);
            Stoper.Reset();



            //SelectionSort(tab);
            //CoctailSort(tab);
            //HeapSort(tab);


            //  foreach (int e in tab)
            //    Console.WriteLine(e);
        }
    }
}
