using System;
using System.IO;
using System.Text;

namespace Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FileStream writerStream = new FileStream("../../../text.txt", FileMode.Append))
            {
                string input = Console.ReadLine();
                while (input != "End")
                {
                    

                    byte[] buffer = Encoding.ASCII.GetBytes(input);
                    writerStream.Write(buffer);

                    input = Console.ReadLine();
                }
            }
            using (FileStream readStream = new FileStream("../../../text.txt", FileMode.Open))
            {
                byte[] buffer = new byte[readStream.Length];

                Console.WriteLine(readStream.Read(buffer));
                string text = Encoding.ASCII.GetString(buffer);
                Console.WriteLine(text);
            }
        }
    }
}
