using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsQueue = new Queue<string>(Console.ReadLine().Split(", "));

            while (songsQueue.Any())
            {
                string[] commands = Console.ReadLine().Split();
                string token = commands[0];

                if (token == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (token == "Add")
                {
                    string songToAdd = string.Join(" ", commands.Skip(1));
                    if (songsQueue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                        continue;
                    }
                    songsQueue.Enqueue(songToAdd);
                }
                else if (token == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }
            Console.WriteLine("No more songs!");
            
        }
    }
}
