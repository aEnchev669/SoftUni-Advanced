using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int daturaBombs = 0;
            int CherryBombs = 0;
            int smokeDekoyBombs = 0;

            int[] effect = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] casing = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> bombEffect = new Queue<int>(effect);
            Stack<int> bombCasing = new Stack<int>(casing);

            if (bombEffect.Count >= 9 && bombCasing.Count >= 9)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }


            while (bombCasing.Count != 0 || bombEffect.Count != 0)
            {
                int effOfBomb = bombEffect.Peek();
                int casingOfBomb = bombCasing.Pop();

                if (effOfBomb + casingOfBomb == 40)
                {
                    daturaBombs++;
                    bombEffect.Dequeue();
                }
                else if (effOfBomb + casingOfBomb == 60)
                {
                    CherryBombs++;
                    bombEffect.Dequeue();

                }
                else if (effOfBomb + casingOfBomb == 120)
                {
                    smokeDekoyBombs++;
                    bombEffect.Dequeue();

                }
                else
                {
                    bombCasing.Push(casingOfBomb - 5);
                }

                if (daturaBombs >= 3 && CherryBombs >= 3 && smokeDekoyBombs >= 3)
                {
                    break;
                }
                if (bombEffect.Count == 0 || bombCasing.Count == 0)
                {
                    break;
                }

            }
            if (bombEffect.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (bombCasing.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            Console.WriteLine($"Cherry Bombs: {CherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDekoyBombs}");


        }
    }
}
