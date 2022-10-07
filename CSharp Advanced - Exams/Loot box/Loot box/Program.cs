using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Loot_box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> firstLootBox = new Queue<int>(firstNumbers); 
            int[] secondNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> secondLootBox = new Stack<int>(secondNumbers);
            string box = string.Empty;
            int sum = 0;
            while (true)
            {
                if (firstLootBox.Count == 0)
                {
                    box = "First";
                    break;
                }
                else if (secondLootBox.Count == 0)
                {
                    box = "Second";
                    break;
                }
                double number = firstLootBox.Peek() + secondLootBox.Peek();
                if (number % 2 == 0)
                {
                    sum+= firstLootBox.Dequeue() + secondLootBox.Pop();
                }
                else
                {
                    firstLootBox.Enqueue(secondLootBox.Pop());
                }
            }
            Console.WriteLine($"{box} lootbox is empty");
            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }

    
    }
}
