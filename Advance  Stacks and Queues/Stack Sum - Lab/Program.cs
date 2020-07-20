using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum___Lab
{
    class Program
    {
        public static object Select { get; private set; }

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackNumbers = new Stack<int>(numbers);

            while (true)
            {
                var commands = Console.ReadLine()
                    .ToLower()
                    .Split();

                var command = commands[0];

                if (command == "add")
                {
                    stackNumbers.Push(int.Parse(commands[1]));
                    stackNumbers.Push(int.Parse(commands[2]));
                }
                else if (command == "remove")
                {
                    var countNumber = int.Parse(commands[1]);

                    if (countNumber < stackNumbers.Count)
                    {
                        while (countNumber > 0)
                        {
                            stackNumbers.Pop();
                            countNumber--;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Sum: {stackNumbers.Sum()}");
        }
    }
}
