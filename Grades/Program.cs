//this lists what assemblies are being used
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object of class gradebook
            GradeBook book = new GradeBook();

            GetBookName(book);

            AddGrades(book);

            SaveGrades(book);
            WriteResults(book);
            Console.WriteLine("this has been a report of " + book.Name + "'s grades");
        }

        private static void WriteResults(GradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest Grade", stats.HighestGrade);
            WriteResult("Lowest Grade", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(GradeBook book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrade(outputFile);
            }
        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrade(50);
            book.AddGrade(65.5f);
            book.AddGrade(10);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Enter a Name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Something went wrong!");
            }
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
        }
    }
}
