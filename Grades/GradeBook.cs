using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        // constructor GradeBook() that just sets grades to be a new List of floats
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        // with virtual keyword, when invoke computestatistics through a variable typed as gradebook,
        // it's no longer going to use the type of variable to figure out which method to call
        
        // instead, it's going to use the type of object, the type that it sees at runtime
        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        // public class members are uppercase while private are lowercased
        // change Name to be a property instead of a field
        // protected code can be accessed by code in this class or by derived classes
        protected List<float> grades;

        // .NET framework type TextWriter
        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }
    }
}