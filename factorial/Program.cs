using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg egy pozitív egész számot:");
            uint number = uint.Parse(Console.ReadLine());

            long factorial = number;

            for (uint i = number; i > 1; i--)
            {
                factorial *= i - 1;
            }
            Console.WriteLine(number + "! = " + factorial);
        }
    }
}
