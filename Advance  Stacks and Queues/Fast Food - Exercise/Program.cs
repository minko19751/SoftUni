using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queueOrders = new Queue<int>(orders);

            if (queueOrders.Any())
            {
                Console.WriteLine(queueOrders.Max());
            }

            for (int i = 0; i < orders.Length; i++)
            {
                int order = orders[i];

                if (quantityFood >= order)
                {
                    quantityFood -= queueOrders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queueOrders)}");
                    break;
                }
            }

            if (queueOrders.Any() == false)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
