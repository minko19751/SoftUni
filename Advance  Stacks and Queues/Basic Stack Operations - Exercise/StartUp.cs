using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations___Exercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //int[] input = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //int[] numbersToStack = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //Stack<int> stack = new Stack<int>();

            //int n = input[0];
            //int s = input[1];
            //int x = input[2];

            //FillStack(numbersToStack, stack, n);

            //DeleteFromStack(stack, s);

            //if (stack.Contains(x))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine(stack.Count > 0 ? stack.Min() : 0);
            //}

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] newNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            int numberOfElementsToPush = numbers[0];
            int numberOfPop = numbers[1];
            int contains = numbers[2];

            for (int i = 0; i < numberOfElementsToPush; i++)
            {
                stack.Push(newNumbers[i]);
            }

            for (int i = 0; i < numberOfPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(contains))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count < 1)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }

        static void DeleteFromStack(Stack<int> stack, int s)
        {
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
        }

        static void FillStack(int[] numbersToStack, Stack<int> stack, int n)
        {
            for (int i = 0; i < n; i++)
            {
                stack.Push(numbersToStack[i]);
            }
        }
    }
}
