using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Fight_for_Gondor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wavesOfOrcs = int.Parse(Console.ReadLine());

            Stack<int> platesOfDefense = new Stack<int>
                (Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse());
            List<int> survivedOrcs = new List<int>();
            for (int i = 1; i <= wavesOfOrcs; i++)
            {
                Stack<int> orcsWarriors = new Stack<int>
                    (Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse));
                if (i % 3 == 0)
                {                                                   
                    int newPlate = int.Parse(Console.ReadLine());
                    var plateAsList = platesOfDefense.ToList();
                    plateAsList.Add(newPlate);
                    plateAsList.Reverse();
                    platesOfDefense = new Stack<int>(plateAsList);
                }
                int count = orcsWarriors.Count;
                for (int orcs = 0; orcs < count; orcs++)
                {
                    int plate = platesOfDefense.Pop();
                    int orc = orcsWarriors.Pop();
                    if (plate > orc)
                    {
                        plate -= orc;
                        platesOfDefense.Push(plate);
                    }
                    else if (plate < orc)
                    {
                        orc -= plate;
                        orcsWarriors.Push(orc);
                    }
                    if (!platesOfDefense.Any())
                    {
                        
                        foreach (var item in orcsWarriors)
                        {
                            survivedOrcs.Add(item);
                        }
                        break;
                    }
                    if (orcs == count && plate > 0)
                    {
                        platesOfDefense.Push(plate);
                    }
                }
                if (!platesOfDefense.Any())
                {
                    break;
                }

            }
            if (!platesOfDefense.Any())
            {
                Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.\nOrcs left: { String.Join(", ", survivedOrcs)}");
            }
            else
            {
                Console.WriteLine($"The people successfully repulsed the orc's attack.\nPlates left: {String.Join(", ", platesOfDefense)}");
            }
            

        }
    }
}
