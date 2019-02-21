using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        // constructor GradeBook() that just sets grades to be a new List of floats
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats =  new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        // public class members are uppercase while private are lowercased
        // change Name to be a property instead of a field
        public string Name
        {
            get { return _name; }
            set
            {
                if (!String.IsNullOrEmpty((value)))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;
                        NameChanged(this, args);
                    }
                    _name = value;
                }
            }
        }

        public event NameChangedDelegate NameChanged;
        
        private string _name;
        private List<float> grades;
    }
}
