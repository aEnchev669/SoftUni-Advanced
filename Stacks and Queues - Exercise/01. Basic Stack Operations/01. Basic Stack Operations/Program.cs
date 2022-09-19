using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numOfElements = nsx[0];
            int numsToPop = nsx[1];
            int numToCheck = nsx[2];

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(nums);
            Stack<int> finalNums = new Stack<int>();
            int smallestNum = int.MaxValue;

            int count = numbers.Count;
            for (int i = 0; i < numsToPop; i++)
            {
                numbers.Pop();
            }

            if (numbers.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < count - numsToPop; i++)
                {
                    int check = numbers.Peek();
                    if (check == numToCheck)
                    {
                        Console.WriteLine("true");
                        return;
                    }
                    else
                    {
                        finalNums.Push(numbers.Pop());
                    }
                }
                for (int i = 0; i < count - numsToPop; i++)
                {
                    if (smallestNum > finalNums.Peek())
                    {
                        smallestNum = finalNums.Pop();
                    }
                }
                Console.WriteLine(smallestNum);
            }
        }
    }
}
