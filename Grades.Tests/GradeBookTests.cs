using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            //making a gradestatistics object calling it result and invoking a method of compute statistics
            GradeStatistics result = book.ComputeStatistics();
            //aserting that the highest grade is in act the highest grade 
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            //making a gradestatistics object calling it result and invoking a method of compute statistics
            GradeStatistics result = book.ComputeStatistics();
            //aserting that the lowest grade is in act the lowest grade 
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            //making a gradestatistics object calling it result and invoking a method of compute statistics
            GradeStatistics result = book.ComputeStatistics();
            //aserting that the average grade is in act the average grade with this we were orignally comparing a double
            //..point precision number with a single point precision which will not work so we are using delta to see if
            //..these two numbers are close enough
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);
        }
    }
}
