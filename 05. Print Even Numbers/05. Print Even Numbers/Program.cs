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
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            Queue<int> queue = new Queue<int>(list);
            Queue<int> oddQueue = new Queue<int>();

            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    oddQueue.Enqueue(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();

                }

            }
            Console.WriteLine(string.Join(", ", oddQueue));


        }
    }
}
