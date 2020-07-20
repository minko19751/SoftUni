using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour___Exercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] currentPumps = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(currentPumps);
            }

            int counter = 0;

            while (true)
            {
                bool startPoints = true;

                int amount = 0;

                //for (int i = 0; i < n; i++)
                //{
                //    int[] currentPump = pumps.Dequeue();

                //    int currentAmount = currentPump[0];
                //    int fuel = currentPump[1];

                //    amount += currentAmount;

                //    if (amount < fuel)
                //    {
                //        startPoints = false;
                //    }

                //    amount -= fuel;

                //    pumps.Enqueue(currentPump);
                //}

                foreach (var pump in pumps)
                {
                    amount += pump[0];

                    if (amount < pump[1])
                    {
                        startPoints = false;
                        break;
                    }

                    amount -= pump[1];
                }

                if (startPoints)
                {
                    break;
                }

                counter++;

                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(counter);
        }
    }
}
