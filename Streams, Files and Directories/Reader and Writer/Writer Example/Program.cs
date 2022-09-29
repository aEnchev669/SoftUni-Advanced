using System;
using System.IO;

namespace Writer_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("../../../scoreboard.txt", true))
            {
                writer.WriteLine("Zdravei");
            }
        }
    }
}
