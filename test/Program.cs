using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
            Console.WriteLine("Hello World!");

            Person p1 = new Person();
            p1.name = "hamzi";
            p1.test();
        }
    }
}
