using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingrCount = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> numberOfIngredients = new Queue<int>(ingrCount);
            int[] lvlOfFreshness = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> levelOfFreshness = new Stack<int>(lvlOfFreshness);

            SortedDictionary<string, int> dishesNum = new SortedDictionary<string, int>();
            dishesNum.Add("Dipping sauce", 0);
            dishesNum.Add("Green salad", 0);
            dishesNum.Add("Chocolate cake", 0);
            dishesNum.Add("Lobster", 0);


            while (true)
            {
                if (levelOfFreshness.Count == 0 || numberOfIngredients.Count == 0)
                {
                    break;
                }
                if (numberOfIngredients.Peek() == 0)
                {
                    numberOfIngredients.Dequeue();
                }
                else
                {
                    int ingredients = numberOfIngredients.Dequeue();
                    int freshness = levelOfFreshness.Pop();
                    int sum = ingredients * freshness;

                    switch (sum)
                    {
                        case 150:
                            dishesNum["Dipping sauce"]++;
                            break;
                        case 250:
                            dishesNum["Green salad"]++;
                            break;
                        case 300:
                            dishesNum["Chocolate cake"]++;
                            break;
                        case 400:
                            dishesNum["Lobster"]++;
                            break;
                        default:
                            numberOfIngredients.Enqueue(ingredients + 5);
                            break;
                    }
                }
            }
            bool masterchef = true;
            foreach (var dishe in dishesNum)
            {
                if (dishe.Value == 0)
                {
                    masterchef = false;
                }
            }

            if (masterchef)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (numberOfIngredients.Any())
            {
                Console.WriteLine($"Ingredients left: {numberOfIngredients.Sum()}");
            }

            foreach (var dishe in dishesNum)
            {
                if (dishe.Value != 0)
                {
                    Console.WriteLine($" # {dishe.Key} --> {dishe.Value}");
                }
            }
        }
    }
}
