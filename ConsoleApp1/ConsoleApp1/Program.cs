using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int computerNumber = random.Next(1, 11);

            int answerCounter = 0;

            bool match = false;

            while (!match && (answerCounter < 10))
            {
                Console.Write("Tippelj: ");
                int myNumber = int.Parse(Console.ReadLine());
                answerCounter++;
                if (myNumber == computerNumber)
                {
                    Console.WriteLine("Kitaláltad!");
                    match = true;
                }
                else if (computerNumber < myNumber)
                {
                    Console.WriteLine("Nem talált! Kisebbre gondoltam.");
                    Console.WriteLine($"Ez volt a {answerCounter}. ötleted.");
                }
                else if (computerNumber > myNumber)
                {
                    Console.WriteLine("Nem talált! Nagyobbra gondoltam.");
                    Console.WriteLine($"Ez volt a {answerCounter}. ötleted");
                }
            }

        }
    }
}
