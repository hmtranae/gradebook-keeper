//using Microsoft.VisualStudio.TestTools.UnitTesting;
//
//namespace Grades.Tests
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//            Assert.AreEqual(3, 3);
//        }
//    }
//}

using System.Reflection;
using NUnit.Framework;
// reference to use the unit testing NUnit

namespace Grades.Tests
{
    [TestFixture]
    public class GradeBookTests
    {
        [Test]
        public void LetterGradeDescription()
        {
            // instantiate a new GradeBook and add grades to it using AddGrade method
            GradeBook book = new GradeBook();
            book.AddGrade(60);
            book.AddGrade(75);
            book.AddGrade(82);
            book.AddGrade(94);

            
            GradeStatistics results = book.ComputeStatistics();
            Assert.AreEqual("Average", results.Description);
        }   
        [Test]
        public void ComputeLetterGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(60);
            book.AddGrade(75);
            book.AddGrade(82);
            book.AddGrade(94);

            GradeStatistics results = book.ComputeStatistics();
            Assert.AreEqual("C", results.LetterGrade);
        }
        [Test]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics results = book.ComputeStatistics();
            Assert.AreEqual(90, results.HighestGrade);
        }
        [Test]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics results = book.ComputeStatistics();
            Assert.AreEqual(10, results.LowestGrade);
        }

        [Test]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics results = book.ComputeStatistics();
            // can specify a delta value after Assert.AreEqual
            // Below case: expected and actual must be within 0.01 of each other
            Assert.AreEqual(85.16, results.AverageGrade, 0.01);
        }
    }
}