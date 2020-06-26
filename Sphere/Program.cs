using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a gömbsugarát: ");
            int radius = int.Parse(Console.ReadLine());

            int surface = (int)(4 * (radius * radius) * 3.14);
            int volume = (int)((4 * (radius * radius * radius) * 3.14) / 3);

            Console.WriteLine("A gömb felszine: " + surface);
            Console.WriteLine("A gömb térfogata: " + volume);

            Console.ReadLine();

        }
    }
}
