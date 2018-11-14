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
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            
            
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
        }
    }
}
