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

            string[] names = Console.ReadLine().Split();
            int times = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>(names);

            while (kids.Count != 1)
            {
                for (int i = 1; i <= times; i++)
                {
                    if (i != times)
                    {
                        string kid = kids.Dequeue();
                        kids.Enqueue(kid);
                    }
                    else
                    {
                        Console.WriteLine($"Removed {kids.Dequeue()}");
                    }
                }
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");





        }
    }
}
