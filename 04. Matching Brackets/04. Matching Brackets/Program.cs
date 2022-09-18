using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startIndex = stack.Pop();
                    Console.WriteLine(expression.Substring(startIndex, i - startIndex + 1));
                }
            }

        }
    }
}
