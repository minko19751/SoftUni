using System;
using System.Collections.Generic;
namespace Reverse_Strings___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] words = Console.ReadLine().ToCharArray();

            Stack<char> text = new Stack<char>(words);

            foreach (var symbol in text)
            {
                Console.Write(symbol);
            }
        }
    }
}
