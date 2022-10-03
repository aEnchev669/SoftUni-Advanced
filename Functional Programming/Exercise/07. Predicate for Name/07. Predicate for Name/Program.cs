using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Predicate_for_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> result = new List<string>();
            Predicate<string> predicateForNames = name => name.Length <= lenght;

            foreach (var name in names)
            {
                result = names.FindAll(predicateForNames);
            }

            Console.WriteLine(string.Join(Environment.NewLine,result));
        }
    }
}
