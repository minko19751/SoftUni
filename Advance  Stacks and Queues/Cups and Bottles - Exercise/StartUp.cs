using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles___Exercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] capacityCups = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray(); 
            int[] capacityBottles = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            Queue<int> cups = new Queue<int>(capacityCups);
            Stack<int> bottles = new Stack<int>(capacityBottles);

            int remainingWater = 0;

            while (cups.Any() && bottles.Any())
            {
                int currentBottles = bottles.Pop();
                int currentCups = cups.Dequeue();

                if (currentBottles - currentCups >= 0)
                {
                    remainingWater += currentBottles - currentCups;
                }
                else
                {
                    currentCups -= currentBottles;

                    while (true)
                    {
                        if (bottles.Any())
                        {
                            int currBottles = bottles.Pop();
                            
                            if (currentCups - currBottles <= 0)
                            {
                                remainingWater += currBottles - currentCups;
                                break;
                            }
                            else
                            {
                                currentCups -= currBottles;
                            }
                        }
                    }
                }
            }

            if (bottles.Any() && cups.Any() == false)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {remainingWater}");
            }
            else if(cups.Any() && bottles.Any() == false)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {remainingWater}");
            }
        }
    }
}
