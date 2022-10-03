using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallestNum = numbers => numbers.Min();
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();
            Console.WriteLine(smallestNum(numbers));
        }
    }
}
