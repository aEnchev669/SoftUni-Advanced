using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            int countOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentsData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string nameOfStudent = studentsData[0];
                decimal grade = decimal.Parse(studentsData[1]);
                if (!studentsGrades.ContainsKey(nameOfStudent))
                {
                    studentsGrades.Add(nameOfStudent, new List<decimal>());
                }
                studentsGrades[nameOfStudent].Add(grade);
            }

            foreach (var student in studentsGrades)
            {
                string name = student.Key;
                var grades = student.Value;
                Console.Write($"{name} ->");
                foreach (var item in grades)
                {
                    Console.Write($" {item:f2}");
                }
                Console.WriteLine($" (avg: {grades.Average():f2})");
                
            }
        }

    }
}
