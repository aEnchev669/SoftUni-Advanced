using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            

            string input = Console.ReadLine();
            while (input != "Party!")
            {
                string[] cmdArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                string criteria = cmdArgs[1];
                string value = cmdArgs[2];

                if (command == "Remove")
                {
                    names.RemoveAll(GetPredicate(criteria, value));
                }
                else if (command == "Double")
                {
                    List<string> peopleToDouble = names.FindAll(GetPredicate(criteria, value));

                    int index = names.FindIndex(GetPredicate(criteria, value));

                    if (index >= 0)
                    {
                        names.InsertRange(index, peopleToDouble);
                    }
                }

                input = Console.ReadLine();
            }

            if (names.Any())
            {
                Console.Write(string.Join(", ", names));
                Console.Write(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "StartsWith":
                    return s => s.StartsWith(value);
                case "EndsWith":
                    return s => s.EndsWith(value);
                case "Length":
                    return s => s.Length == int.Parse(value);
                default:
                    return default(Predicate<string>);
            }
        }

    }
}
