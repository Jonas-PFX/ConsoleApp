using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass TC = new TestClass("Hello Class!");
            PrintSomething("Hello World!");
            PrintSomething(TC.TestProp);

            List<string> minLista = new List<string>();
            minLista.Add("Hello");
            minLista.Add("World");
            minLista.Add("From");
            minLista.Add("List!");

            PrintSomething(String.Join(" ",minLista));
        }


        static void PrintSomething(string inStr) {
            Console.WriteLine($"Printing.. {inStr}");
        }
    }
}
