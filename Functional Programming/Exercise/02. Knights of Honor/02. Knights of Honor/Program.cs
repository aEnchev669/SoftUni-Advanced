using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Action<string[]> printNames = names =>
            {
                foreach (var name in names)
                {
                    Console.WriteLine($"Sir {name}");
                }
            };

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(names);

        }

    }
}
