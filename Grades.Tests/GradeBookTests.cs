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

using NUnit.Framework;

namespace Grades.Tests
{
    [TestFixture]
    public class GradeBookTests
    {
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
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics results = book.ComputeStatistics();
            Assert.AreEqual(50, results.AverageGrade);
        }
    }
}