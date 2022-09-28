using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sortedNumbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).ToArray();
            if (sortedNumbers.Length < 3)
            {
                for (int i = 0; i < sortedNumbers.Length; i++)
                {
                    Console.Write($"{sortedNumbers[i]} ");
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{sortedNumbers[i]} ");
                }
            }
        }
    }
}
