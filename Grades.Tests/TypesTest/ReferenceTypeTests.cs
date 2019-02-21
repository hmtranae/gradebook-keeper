using System;
using NUnit.Framework;

// namespace should match the repository name
namespace Grades.Tests.TypesTest
{
    [TestFixture]
    public class TypeTests
    {
        [Test]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);
            
            Assert.AreEqual(47, x);
        }

        // Doesn't matter what you do to the number inside of the private functon IncrementNumber because changes are only visible inside of IncrementNumber
        private void IncrementNumber(ref int number)
        {
            number += 1;
        }
        
        [Test]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            
            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book2.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            // the line below will not change the reference of book1 or book2
            // only the value is taken when the method is called
            // book = new GradeBook();
            book.Name = "A GradeBook";
        }
        
        
        [Test]
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [Test]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Scott's grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }

        [Test]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }
    }
}