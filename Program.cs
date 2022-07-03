using System;

namespace wykład_test_1
{
    class Test
    {
        int nr;
        public Test() { 
            Console.WriteLine("Blabla " + this + nr);
        }
        public Test(int _nr)
        {
            nr = _nr;
            Console.WriteLine("Blabla " + this + nr);
        }
        public static void Ka() { Console.WriteLine("aaa"); }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Test Test1 = new Test();
            Test Test2 = new Test(5);
            Test.Ka();
            
        }
    }
}
