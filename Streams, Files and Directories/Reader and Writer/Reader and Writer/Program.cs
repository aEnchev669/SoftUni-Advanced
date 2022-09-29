using System;
using System.Collections.Generic;
using System.IO;

namespace Stream__Files_and_directories
{
    internal class Program
    {
        class Player
        {
            public string Name { get; set; }
            public int Score { get; set; }
        }
        static void Main(string[] args)
        {

            List<Player> players = new List<Player>();
            using (StreamReader reader = new StreamReader("../../../scoreboard.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] scoreboard = reader.ReadLine().Split(" - ");
                    string name = scoreboard[0];
                    int score = int.Parse(scoreboard[1]);

                    players.Add(new Player()
                    {
                        Name = name,
                        Score = score
                    });

                }
                
            }
            using (StreamWriter writer = new StreamWriter("../../../scoreboard.txt"))
            {
                foreach (Player player in players)
                {
                    writer.WriteLine($"{player.Name} - {player.Score + 10}");
                }
            }

            
        }
    }
}
