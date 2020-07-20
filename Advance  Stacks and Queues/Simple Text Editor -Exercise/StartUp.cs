using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Text_Editor__Exercise
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string emptyText = string.Empty;

            Stack<string> stackSb = new Stack<string>();
            stackSb.Push(emptyText);

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                string currentCommand = commandArgs[0];

                switch (currentCommand)
                {
                    case "1":

                        string text = commandArgs[1];

                        string str = stackSb.Peek();

                        for (int j = 0; j < text.Length; j++)
                        {
                             str += text[j];
                        }

                        stackSb.Push(str);

                        break;

                    case "2":

                        int countRemoveLastEl = int.Parse(commandArgs[1]);

                        string currentText = stackSb.Peek();
                        currentText = currentText.Remove(currentText.Length - countRemoveLastEl, countRemoveLastEl);
                        stackSb.Push(currentText);

                        break;

                    case "3":

                        int index = int.Parse(commandArgs[1]);

                        if (index >= 1 && index <= stackSb.Peek().Length)
                        {
                            string currSymbol = stackSb.Peek().Substring(index - 1, 1);

                            Console.WriteLine(currSymbol);
                        }

                        break;

                    case "4":

                        stackSb.Pop();

                        break;
                }
            }
        }
    }
}
