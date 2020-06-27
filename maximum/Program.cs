using System;

namespace ConsoleApp3
{
    class Program
    {
        static int IndexOfBestWeapon(int[] weaponData)
        {
            int bestIndex = 0;
            
            for (int i = 1; i < weaponData.Length; i++)
            {
                if(weaponData[i] > weaponData[bestIndex])
                {
                    bestIndex = i;
                }
            }

            return bestIndex;
        }

        static void Main(string[] args)
        {
            int[] damages = { 20, 50, 10, 200, 50, 140 };

            Console.WriteLine("A legjobb fegyver: {0}", IndexOfBestWeapon(damages));
        }
    }
}
