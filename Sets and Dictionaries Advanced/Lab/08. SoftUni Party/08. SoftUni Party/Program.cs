using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> party = new List<string>();

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
                for (int i = 0; i < party.Count; i++)
                {
                    string partyMember = party[i];
                    if (char.IsDigit(partyMember[i]))
                    {
                        Console.WriteLine(partyMember);
                        party.Remove(partyMember);
                    }
                }
                if (party.Count > 0)
                {
                    foreach (var member in party)
                    {
                        Console.WriteLine(member);
                    }
                }
            }
        }
    }
}
