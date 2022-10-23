using System;

namespace ComputerArchitecture
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository
            //Computer computer = new Computer("Gaming Serioux", 4);

            // Initialize entity
            CPU cpu = new CPU("AMD Ryzen 5", 6, 3.7);

            // Print CPU
            Console.WriteLine(cpu);
            // AMD Ryzen 5 CPU:
            // Cores: 6
            // Frequency: 3.7 GHz

        }
    }
}
