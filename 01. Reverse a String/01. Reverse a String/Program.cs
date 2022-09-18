using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            int lenght = stack.Count;
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
