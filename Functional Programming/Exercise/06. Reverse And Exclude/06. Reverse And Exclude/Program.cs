using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();
            List<int> result = new List<int>();

            int divideBy = int.Parse(Console.ReadLine());

            Predicate<int> collection = number => number % divideBy != 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                result = numbers.FindAll(collection);
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ",result));

        }
    }
}
