using System.Collections;
using System.IO;

namespace Grades
{
    public interface IGradeTracker : IEnumerable
    {
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrades(TextWriter destination);
        string Name { get; set; }
    }
}