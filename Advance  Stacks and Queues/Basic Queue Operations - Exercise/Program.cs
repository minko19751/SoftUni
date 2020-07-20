using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = input[0];
            int s = input[1];
            int x = input[2];

            Queue<int> queue = new Queue<int>(numbers);
            //Queue<int> queue = new Queue<int>();

            //FillQueue(numbers, n, queue);

            DeleteElements(s, queue);

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Count > 0 ? queue.Min() : 0);

                //if (queue.Count > 0)
                //{
                //    Console.WriteLine(queue.Min());
                //}
                //else
                //{
                //    Console.WriteLine("0");
                //}
            }
        }

        private static void DeleteElements(int s, Queue<int> queue)
        {
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
        }

        private static void FillQueue(int[] numbers, int n, Queue<int> queue)
        {
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbers[i]);
            }
        }
    }
}
