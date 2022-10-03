using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<int> sequence = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> numbers = new List<int>();
            List<int> result = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                numbers.Add(i);
            }
            for (int i = 0; i < sequence.Count; i++)
            {
                Predicate<int> deivideBy = number => number % sequence[i] == 0;
                result = numbers.FindAll(deivideBy);
                numbers = result;
            }
            
            Console.WriteLine(String.Join(" ",result));       
        }
    }
}
