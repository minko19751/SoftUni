using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads___Exercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            bool crash = false;
            int counter = 0;
            int hitIndex = -1;
            string currentCarCrash = string.Empty;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                else if (command == "green")
                {
                    int currGreenLight = greenLight;

                    while (cars.Any())
                    {
                        string currentCar = cars.Peek();
                        int lengthCurrentCar = currentCar.Length;

                        if (currGreenLight - lengthCurrentCar > 0)
                        {
                            currGreenLight -= lengthCurrentCar;
                            cars.Dequeue();
                            counter++;
                        }
                        else
                        {
                            if (currGreenLight + freeWindow >= lengthCurrentCar)
                            {
                                cars.Dequeue();
                                counter++;
                            }
                            else
                            {
                                currentCarCrash = currentCar;
                                crash = true;
                                hitIndex = currGreenLight + freeWindow;
                            }

                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                if (crash)
                {
                    break;
                }
            }

            if (crash)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{currentCarCrash} was hit at {currentCarCrash[hitIndex]}.");
            }
            else
            {
                Console.WriteLine($"Everyone is safe.");
                Console.WriteLine($"{counter} total cars passed the crossroads.");
            }
        }
    }
}
