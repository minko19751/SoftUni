using System;
using System.Collections.Generic;
using System.Linq;

namespace Traffic_Jam___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCar = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            var countPassedCar = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "green")
                {
                    for (int i = 0; i < numberOfCar; i++)
                    {
                        if (queue.Any())
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");

                            countPassedCar++;
                        }
                    }
                }
                else if (command == "end")
                {
                    Console.WriteLine($"{countPassedCar} cars passed the crossroads.");
                    break;
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
        }
    }
}
