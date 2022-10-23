using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _22._10._2022_Exam_C__Sharp_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] coffe = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] drinkss = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> miligramsOfCoffeine = new Stack<int>(coffe);
            Queue<int> energyDrinks = new Queue<int>(drinkss);

            int stamatCoffeine = 0;

            while (miligramsOfCoffeine.Count > 0 && energyDrinks.Count > 0)
            {
               int coffeine = miligramsOfCoffeine.Pop();
                int energy = energyDrinks.Dequeue();

                if (coffeine * energy + stamatCoffeine <= 300)
                {
                    stamatCoffeine += coffeine * energy;
                }
                else
                {
                    energyDrinks.Enqueue(energy);
                    if (stamatCoffeine >= 30)
                    {
                        stamatCoffeine -= 30;
                    }
                }
            }

            if (energyDrinks.Count != 0)
            {
                Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
            }
            else
            {
                Console.WriteLine($"At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {stamatCoffeine} mg caffeine.");
        }
    }
}
