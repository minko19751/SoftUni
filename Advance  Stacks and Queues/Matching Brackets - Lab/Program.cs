using System;
using System.Collections.Generic;

namespace Matching_Brackets___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                var symbol = text[i];
                if (symbol == '(')
                {
                    stack.Push(i);
                }
                else if (symbol == ')')
                {
                    int index = stack.Pop();
                    result = text.Substring(index, i - index + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
