using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = Console.ReadLine().Split(" ").OrderBy(x => x).ToArray();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
