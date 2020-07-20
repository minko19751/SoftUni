using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver___Exercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int[] locks = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();
            int valueIntelligence = int.Parse(Console.ReadLine());

            int countBullets = 0;

            Stack<int> stackBullets = new Stack<int>(bullets);
            Queue<int> queueLocks = new Queue<int>(locks);

            int counter = 0;

            while (stackBullets.Any() && queueLocks.Any())
            {
                countBullets++;

                int currentBullets = stackBullets.Pop();
                int currentLocks = queueLocks.Peek();

                if (currentBullets <= currentLocks)
                {
                    Console.WriteLine("Bang!");
                    queueLocks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                counter++;

                if (counter == sizeOfGunBarrel && stackBullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    counter = 0;
                }
            }

            if (queueLocks.Any() == false)
            {
                int bulletCost = priceOfBullet * countBullets;
                int earned = valueIntelligence - bulletCost;
                Console.WriteLine($"{stackBullets.Count} bullets left. Earned ${earned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
            }
        }
    }
}
