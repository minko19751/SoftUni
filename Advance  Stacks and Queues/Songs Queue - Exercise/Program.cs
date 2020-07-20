using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Queue<string> queueSongs = new Queue<string>(songs);

            while (queueSongs.Any())
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (cmdArgs[0] == "Add")
                {
                    string song = string.Empty;

                    for (int i = 1; i < cmdArgs.Length; i++)
                    {
                        if (i == cmdArgs.Length - 1)
                        {
                            song += cmdArgs[i];
                        }
                        else
                        {
                            song += cmdArgs[i];
                            song += " ";
                        }
                    }

                    if (queueSongs.Contains(song) == false)
                    {
                        queueSongs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (cmdArgs[0] == "Play")
                {
                    queueSongs.Dequeue();
                }
                else if (cmdArgs[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", queueSongs));
                }
            }

            Console.WriteLine($"No more songs!");
        }
    }
}
