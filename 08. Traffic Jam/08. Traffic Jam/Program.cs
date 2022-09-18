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

            int numOfCarsPass = int.Parse(Console.ReadLine());
            Queue<string> traffic = new Queue<string>();
            string commands = Console.ReadLine();
            int carsPassed = 0;
            while (commands != "end")
            {
                if (commands == "green")
                {


                    for (int i = 0; i < numOfCarsPass; i++)
                    {
                        if (traffic.Count != 0)
                        {
                            carsPassed++;
                            Console.WriteLine($"{traffic.Dequeue()} passed!");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    traffic.Enqueue(commands);
                }


                commands = Console.ReadLine();
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");





        }
    }
}
