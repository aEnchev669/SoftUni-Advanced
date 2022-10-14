using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Food_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pear = "pear";
            string flour = "flour";
            string pork = "pork";
            string olive = "olive";


            Queue vowels = new Queue(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries));
            Stack consonants = new Stack(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries));
            List<string> wordsFound = new List<string>();
            while (consonants.Count != 0)
            {
                char firstLetter = char.Parse(vowels.Dequeue().ToString());
                char secondLetter = char.Parse(consonants.Pop().ToString());
                if (pear.Length != 0)
                { 
                    if (pear.Contains(firstLetter))
                    {
                        int index = pear.IndexOf(firstLetter);
                        pear = pear.Remove(index, 1);

                    }
                    if (pear.Contains(secondLetter))
                    {
                        int index = pear.IndexOf(secondLetter);
                        pear = pear.Remove(index, 1);
                    }
                }
                if (flour.Length != 0)
                {
                    if (flour.Contains(firstLetter))
                    {
                        int index = flour.IndexOf(firstLetter);
                        flour = flour.Remove(index, 1);

                    }
                    if (flour.Contains(secondLetter))
                    {
                        int index = flour.IndexOf(secondLetter);
                        flour = flour.Remove(index, 1);
                    }
                }
                if (pork.Length != 0)
                {
                    if (pork.Contains(firstLetter))
                    {
                        int index = pork.IndexOf(firstLetter);
                        pork = pork.Remove(index, 1);

                    }
                    if (pork.Contains(secondLetter))
                    {
                        int index = pork.IndexOf(secondLetter);
                        pork = pork.Remove(index, 1);
                    }
                }
                if (olive.Length != 0)
                {
                    if (olive.Contains(firstLetter))
                    {
                        int index = olive.IndexOf(firstLetter);
                        olive = olive.Remove(index, 1);

                    }
                    if (olive.Contains(secondLetter))
                    {
                        int index = olive.IndexOf(secondLetter);
                        olive = olive.Remove(index, 1);
                    }
                }
                vowels.Enqueue(firstLetter);
            }

            if (pear.Length == 0)
            {
                wordsFound.Add("pear");
            }
            if (flour.Length == 0)
            {
                wordsFound.Add("flour");
            }
            if (pork.Length == 0)
            {
                wordsFound.Add("pork");
            }
            if (olive.Length == 0)
            {
                wordsFound.Add("olive");
            }

            Console.WriteLine($"Words found: {wordsFound.Count}");
            if (wordsFound.Count > 0)
            {
                foreach (var item in wordsFound)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
