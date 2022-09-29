using System;
using System.Collections.Generic;

namespace _09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ExamResult> result = new List<ExamResult>();

            string cmd = Console.ReadLine();
            while (cmd != "exam finished")
            {
                string[] tokens = cmd.Split('-',StringSplitOptions.RemoveEmptyEntries);
                if (result.co)
                {

                }


            }
        }
        public class ExamResult
        { 
            public string Name { get; set; }
            public string Language { get; set; }
            public int Points { get; set; }
        }
    
    }
}
