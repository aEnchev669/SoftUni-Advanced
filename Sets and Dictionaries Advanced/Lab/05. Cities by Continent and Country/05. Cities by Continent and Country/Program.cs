using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }
                continents[continent][country].Add(city);
            }

            foreach (var conti in continents)
            {
                Console.WriteLine($"{conti.Key}:");
                foreach (var items in conti.Value)
                {
                    Console.Write($"  {items.Key} -> ");
                    for (int i = 0; i < items.Value.Count; i++)
                    {
                        Console.Write($"{items.Value[i]}");
                        if (i == items.Value.Count - 1)
                        {
                            break;
                        }
                        Console.Write($", ");
                    }
                    Console.WriteLine();
                }
                
            }
            
        }
    }
}
