using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> negative = new List<int>();
            List<int> positive = new List<int>();

            int numberCounter = 0;

            while (numberCounter < 10)
            {
                Console.WriteLine("Adj meg egy számot: ");
                int number = int.Parse(Console.ReadLine());
                numberCounter++;
                if (number > 0)
                {   
                    positive.Add(number);
                }
                else if (number < 0)
                {
                    negative.Add(number);
                }
                if (numberCounter == 10)
                {
                    Console.WriteLine("Pozitív számok száma: " + positive.Count);
                    Console.WriteLine("Negatív számok száma: " + negative.Count);
                }
            }
        }
    }
}
