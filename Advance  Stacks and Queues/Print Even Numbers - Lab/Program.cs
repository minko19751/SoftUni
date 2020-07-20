using System;
using System.Linq;
using System.Collections.Generic;

namespace Print_Even_Numbers___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(numbers.Where(x => x % 2 == 0));

            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        queue.Enqueue(number);
            //    }
            //}

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
