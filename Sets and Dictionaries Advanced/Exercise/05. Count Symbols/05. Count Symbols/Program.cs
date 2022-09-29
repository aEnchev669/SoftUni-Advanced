using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SortedDictionary<char, int> countOfChars = new SortedDictionary<char, int>();

            string words = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                if (!countOfChars.ContainsKey(words[i]))
                {
                    countOfChars.Add(words[i], 1);
                }
                else
                {
                    countOfChars[words[i]]++;
                }
            }
            foreach (var symbol in countOfChars)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
