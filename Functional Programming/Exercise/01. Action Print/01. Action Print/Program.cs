 using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Action<string[]> printStrings = strings => Console.WriteLine(string.Join(Environment.NewLine, strings));

            string[] strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printStrings(strings);
            
        }
      
    }
}
