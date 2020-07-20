using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element___Exercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            Stack<int> mins = new Stack<int>();
            mins.Push(int.MaxValue);

            Stack<int> maxs = new Stack<int>();
            maxs.Push(int.MinValue);

            for (int i = 1; i <= number; i++)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                switch (command[0])
                {
                    case "1":

                        int element = int.Parse(command[1]);

                        stack.Push(element);

                        if (element > maxs.Peek())
                        {
                            maxs.Push(element);
                        }

                        if (element < mins.Peek())
                        {
                            mins.Push(element);
                        }

                        break;

                    case "2":

                        if (stack.Any())
                        {
                            int el = stack.Pop();

                            if (maxs.Peek() == el)
                            {
                                maxs.Pop();
                            }

                            if (mins.Peek() == el)
                            {
                                mins.Pop();
                            }
                        }

                        break;

                    case "3":

                        Console.WriteLine(maxs.Peek());

                        break;

                    case "4":

                        Console.WriteLine(mins.Peek());

                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
