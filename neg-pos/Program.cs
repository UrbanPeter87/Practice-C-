using System;

namespace ConsoleApp3
{
    class Program
    {
        static int[] FirstNumbersOfAnArray(int length) 
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                if(i % 2 == 0)
                {
                    array[i] = -1 * i;
                }
                else
                {
                    array[i] = i;
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] first20 = FirstNumbersOfAnArray(20);

            foreach (int number in first20)
            {
                Console.Write(number  + ",");
            }
        }
    }
}
