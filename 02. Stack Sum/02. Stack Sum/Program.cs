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

            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>(nums);

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if (tokens[0] == "remove")
                {
                    int elementsToRemove = int.Parse(tokens[1]);
                    if (elementsToRemove <= stack.Count)
                    {
                        for (int i = 0; i < elementsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            int count = stack.Count;
            //int sum = 0;
            //for (int i = 0; i < count; i++)
            //{
            //    sum += stack.Pop();
            //}
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
