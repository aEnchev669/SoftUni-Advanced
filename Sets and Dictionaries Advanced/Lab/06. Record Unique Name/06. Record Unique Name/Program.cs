using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Record_Unique_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> setOfNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
               setOfNames.Add(Console.ReadLine());
            }

            foreach (var name in setOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
