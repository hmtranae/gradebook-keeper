using NUnit.Framework;

// namespace should match the repository name
namespace Grades.Tests.TypesTest
{
    [TestFixture]
    public class ReferenceTypeTests
    {
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
            Assert.AreEqual(x1, x2);
        }
    }
}