using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedSet<string> party = new SortedSet<string>();    

            while (input != "PARTY")
            {
                if (!party.Contains(input))
                {
                    party.Add(input);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "END")
            {
                
                if (party.Contains(input))
                {
                    party.Remove(input);
                }
               
                input = Console.ReadLine();
            }
            
            
            Console.WriteLine(party.Count);
            if (party.Count > 0)
            {
                foreach (var item in party)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
