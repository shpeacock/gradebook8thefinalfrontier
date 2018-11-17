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
            //using a method from gradebook to add grades to a list of this object/instance of gradebook
            book.NameChanged = new NameChangedDelegate(OnNameChanged);
            book.Name = "Spences Gradebook";

         
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            
            
            GradeStatistics stats = book.ComputeStatistics();
         //
            WriteResult("Average" , stats.AverageGrade);
            WriteResult("Highest Grade", stats.HighestGrade);
            WriteResult("Lowest Grade" ,stats.LowestGrade);

        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
        }

        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Grade Book Changing Name From {existingName} to {newName}");
        }
    }
}
