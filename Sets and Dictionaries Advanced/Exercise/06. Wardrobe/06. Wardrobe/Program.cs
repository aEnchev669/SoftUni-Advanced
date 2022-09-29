using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,int>> wardrobe = new Dictionary<string, Dictionary<string,int>>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] colorAndClothes = Console.ReadLine().Split(" -> ");
                string[] clothes = colorAndClothes[1].Split(',');
                if (!wardrobe.ContainsKey(colorAndClothes[0]))
                {
                    wardrobe.Add(colorAndClothes[0], new Dictionary<string, int>());
                }
                foreach (var item in clothes)
                {
                    if (!wardrobe[colorAndClothes[0]].ContainsKey(item))
                    {
                        wardrobe[colorAndClothes[0]].Add(item, 0);
                    }

                    wardrobe[colorAndClothes[0]][item]++;
                   
                }
            }

            string[] dressToCheck = Console.ReadLine().Split();
            foreach (var colors in wardrobe)
            {
                string color = colors.Key;
                Console.WriteLine($"{color} clothes:");
                foreach (var clothes in colors.Value)
                {
                    string clothing = clothes.Key;
                    int count = clothes.Value;
                    if (color == dressToCheck[0] && clothing == dressToCheck[1])
                    {
                       Console.WriteLine($"* {clothing} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing} - {count}");
                    }
                }
            }
        }
    }
}
