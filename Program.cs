using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass TC = new TestClass("Hello Class!");
            PrintSomething("Hello World!");
            PrintSomething(TC.TestProp);
        }


        static void PrintSomething(string inStr) {
            Console.WriteLine($"Printing.. {inStr}");
        }
    }
}
