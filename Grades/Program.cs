//this lists what assemblies are being used
using System;
using System.Collections.Generic;
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
            
            book.AddGrade(50);
            book.AddGrade(65.5f);
            book.AddGrade(10);

            GradeStatistics stats = book.ComputeStatistics();
        
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest Grade", stats.HighestGrade);
            WriteResult("Lowest Grade", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
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
