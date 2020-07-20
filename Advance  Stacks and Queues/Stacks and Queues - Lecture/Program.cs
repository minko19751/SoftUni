using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues___Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();

            //list.Add("first");
            //list.Add("second");

            //var myStack = new Stack<string>();

            //myStack.Push("first");
            //myStack.Push("second");
            //myStack.Push("third");

            //var result = myStack.Pop();

            //Console.WriteLine(result);

            //Console.WriteLine(myStack.Count);

            /////////////////////////////////////////////////////

            //var myStack = new Stack<int>();

            //myStack.Push(10);
            //myStack.Push(20);
            //myStack.Push(30);

            //Console.WriteLine(myStack.Contains(4));//false
            //Console.WriteLine(myStack.Count);//3
            //Console.WriteLine(myStack.Pop());//30
            //Console.WriteLine(myStack.Count);//2
            //Console.WriteLine(myStack.Peek());//20
            //Console.WriteLine(myStack.Count);//2

            //Console.WriteLine(myStack.Pop());


            //Console.WriteLine(myStack.Pop());

            //int result = 0;
            //var otherResult = myStack.TryPop(out result);

            //if (myStack.TryPop(out var result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Stack is empty.");
            //}

            /////////////////////////////////////////////////////////////////////


            //string text = "some text";

            ////int result = 0;
            ////var parsed = int.TryParse(text, out var result);

            //if (int.TryParse(text, out var result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("invalid input");
            //}

            ///////////////////////////////////////////////////////////////////


            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var stackNumbers = new Stack<int>(numbers);

            while (true)
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split()
                    .ToArray();

                if (input[0] == "add")
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        stackNumbers.Push(int.Parse(input[i]));
                    }
                }
                else if (input[0] == "remove")
                {
                    int number = int.Parse(input[1]);

                    if (number < stackNumbers.Count)
                    {
                        while (number > 0)
                        {
                            stackNumbers.Pop();
                            number--;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(stackNumbers.Sum());
        }
    }
}
