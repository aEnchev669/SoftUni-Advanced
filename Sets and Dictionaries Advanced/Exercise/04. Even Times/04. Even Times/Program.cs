using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> evenTimes = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            int evenNumber = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (!evenTimes.ContainsKey(numbers))
                {
                    evenTimes.Add(numbers, 1);
                }
                else
                {
                    evenTimes[numbers]++;
                }
            }

            foreach (var item in evenTimes)
            {
                if (item.Value % 2 ==0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
            
        }
    }
}
