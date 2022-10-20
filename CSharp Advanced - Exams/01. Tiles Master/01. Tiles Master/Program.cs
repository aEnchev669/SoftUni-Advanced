using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tiles1 = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] tiles2 = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> whiteTiles = new Stack<int>(tiles1);
            Queue<int> greyTiles = new Queue<int>(tiles2);

            Dictionary<string, int> kithcenDecor = new Dictionary<string, int>()
            {
                {"Sink", 40 },
                {"Oven", 50 },
                {"Countertop", 60},
                {"Wall", 70 }
            };
            Dictionary<string, int> location = new Dictionary<string, int>()
            {
                {"Sink", 0 },
                {"Oven", 0 },
                {"Countertop", 0},
                {"Wall", 0},
                {"Floor", 0 }
            };

            while (true)
            {
                if (whiteTiles.Count == 0)
                {
                    break;
                }
                if (greyTiles.Count == 0)
                {
                    break;
                }
                int whiteTile = whiteTiles.Pop();
                int greyTile = greyTiles.Dequeue();

                if (whiteTile == greyTile)
                {
                    int newTile = whiteTile + greyTile;

                    KeyValuePair<string, int> possibleLoc = kithcenDecor.FirstOrDefault(x => x.Value == newTile);

                    if (possibleLoc.Key != null)
                    {
                        location[possibleLoc.Key]++;
                    }
                    else
                    {
                        location["Floor"]++;
                    }
                }
                else
                {
                    whiteTiles.Push(whiteTile / 2);
                    greyTiles.Enqueue(greyTile);
                }
            }
            if (whiteTiles.Count > 0)
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
            }
            else
            {
                Console.WriteLine($"White tiles left: none");
            }

            if (greyTiles.Count > 0)
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }

            location = location.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(l => l.Key, l => l.Value);

            foreach (var item in location)
            {
                if (item.Value != 0)
                {
                Console.WriteLine($"{item.Key}: {item.Value}");

                }
            }
        }
    }
}
