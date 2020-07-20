using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> priceClothing = new Stack<int>(box);

            int price = int.Parse(Console.ReadLine());

            int countClothing = 1;
            int sumPrice = 0;

            while (priceClothing.Any())
            {
                int currentPrice = priceClothing.Pop();

                sumPrice += currentPrice;

                if (price < sumPrice)
                {
                    sumPrice = 0;
                    countClothing++;
                    priceClothing.Push(currentPrice);
                }
            }

            Console.WriteLine(countClothing);
        }
    }
}
