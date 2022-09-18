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

            Queue<string> names = new Queue<string>();


            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "Paid")
                {
                    int count = names.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else
                {
                    names.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");

        }
    }
}
