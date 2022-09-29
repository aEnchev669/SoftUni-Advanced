using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicaCompounds = new SortedSet<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] element = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in element)
                {
                  chemicaCompounds.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", chemicaCompounds));
            
        }
    }
}
