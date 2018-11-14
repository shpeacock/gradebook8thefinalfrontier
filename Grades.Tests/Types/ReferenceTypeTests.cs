using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void VariablesHoldAReference()
        {
            // instantiate a new gradebook
            GradeBook g1 = new GradeBook();
            //creating two variables taht are pointing to the same gradebook
            GradeBook g2 = g1;

            g1.Name = "spence grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
