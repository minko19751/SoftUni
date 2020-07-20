using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split();

            var result = new Stack<string>(numbers.Reverse());

            while (result.Count > 1)
            {
                int firstNumber = int.Parse(result.Pop().ToString());
                string symbol = result.Pop().ToString();
                int secondNumber = int.Parse(result.Pop().ToString());

                var tempResult = symbol switch
                {
                    "+" => (firstNumber + secondNumber),
                    "-" => (firstNumber - secondNumber),
                    _ => 0
                };

                result.Push(tempResult.ToString());
            }

            Console.WriteLine(result.Peek());
        }
    }
}
