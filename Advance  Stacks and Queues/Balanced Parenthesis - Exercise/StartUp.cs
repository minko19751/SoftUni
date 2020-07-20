using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parenthesis___Exercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            char[] inputSymbols = Console.ReadLine()
                .ToCharArray();

            Stack<char> symbols = new Stack<char>();

            bool isSymbol = true;

            for (int i = 0; i < inputSymbols.Length; i++)
            {
                char currentSymbol = inputSymbols[i];

                switch (currentSymbol)
                {
                    case '{':
                    case '[':
                    case '(':

                        symbols.Push(currentSymbol);

                        break;

                    case '}':

                        if (symbols.Any() == false)
                        {
                            isSymbol = false;
                            break;
                        }

                        if (symbols.Pop() != '{')
                        {
                            isSymbol = false;
                            break;
                        }

                        break;

                    case ']':

                        if (symbols.Any() == false)
                        {
                            isSymbol = false;
                            break;
                        }

                        if (symbols.Pop() != '[')
                        {
                            isSymbol = false;
                            break;
                        }
                        break;

                    case ')':

                        if (symbols.Any() == false)
                        {
                            isSymbol = false;
                            break;
                        }

                        if (symbols.Pop() != '(')
                        {
                            isSymbol = false;
                            break;
                        }

                        break;
                }
            }

            //if (isSymbol)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            Console.WriteLine(isSymbol ? "YES" : "NO");
        }
    }
}
