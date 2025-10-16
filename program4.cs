using System;

namespace TestPolymorphism
{
    class TestOverload
    {
        public void DisplayOverload(int a)
        {
            Console.WriteLine("DisplayOverload(int): " + a);
        }

        public void DisplayOverload(string a)
        {
            Console.WriteLine("DisplayOverload(string): " + a);
        }

        public void DisplayOverload(string a, int b)
        {
            Console.WriteLine("DisplayOverload(string, int): " + a + ", " + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestOverload to = new TestOverload();

            to.DisplayOverload(100);
            to.DisplayOverload("aaa");
            to.DisplayOverload("bbb", 2);

            Console.ReadKey();
        }
    }
}
