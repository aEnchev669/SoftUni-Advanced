using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int countOfNumbers = nsx[0];
            int numsToPop = nsx[1];
            int numToCheck = nsx[2];

            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            
            for (int i = 0; i < numsToPop; i++)
            {
                numbers.Dequeue();
            }

            int count = numbers.Count;
            if (numbers.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (numToCheck == numbers.Peek())
                    {
                        Console.WriteLine("true");
                        return;
                    }
                    else
                    {
                        numbers.Enqueue(numbers.Dequeue());
                    }
                }
                int minNum = int.MaxValue;
                for (int i = 0; i < count; i++)
                {
                    if (minNum > numbers.Peek())
                    {
                        minNum = numbers.Dequeue();
                    }
                }
                Console.WriteLine(minNum);
            }
        }
    }
}
