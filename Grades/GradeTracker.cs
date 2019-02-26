using System;
using System.IO;

namespace Grades
{
    // abstract/pure class details things the user can do without worrying about the implementation
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);
        
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty((value)))
                {
                    // ArgumentException is one of many exceptions that .NET framework has
                    throw new ArgumentException("Name cannot be null or empty.");
                }

                if (_name != value && NameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;
                    NameChanged(this, args);
                }

                _name = value;
            }
        }

        public event NameChangedDelegate NameChanged;

        protected string _name;

    }
}