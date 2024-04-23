using System;
using ClassLibrary1;

namespace FwTestApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var testClass = new TestClass();
            var value = testClass.TestMethod(1);
            Console.WriteLine($"The value of key 1 is {value}");
        }
    }
}