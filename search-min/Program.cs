using System;

namespace ConsoleApp3
{
    class Program
    {
        static int[] CreateArrayWithRandomValues(Random random, int count)
        {
            int[] result = new int[count];

            for(int i = 0; i < count; i++)
            {
                result[i] = random.Next(1, 101);
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            Random sourceOfRandomness = new Random();

            int[] numbers = CreateArrayWithRandomValues(sourceOfRandomness, 10);

            for(int i = numbers.Length; i >= 0; i--)
            {
                for(int j = 0; j < i-1; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            foreach(var item in numbers)
            {
                Console.Write(item.ToString() + ",");
            }

            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.Write("\nA legkisebb elem: " + min);
        }
    }
}
