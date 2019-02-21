﻿using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace Grades{    class Program    {        static void Main(string[] args)         {            GradeBook book = new GradeBook();            book.AddGrade(91);            book.AddGrade(75);            book.AddGrade(89.5f);            GradeStatistics stats = book.ComputeStatistics();            WriteResult("Average", stats.AverageGrade);            // C# type cast (int) to change to int value            WriteResult("Highest", (int)stats.HighestGrade);            WriteResult("Lowest", stats.LowestGrade);        }        static void WriteResult(string description, int result)        {            Console.WriteLine(description + ": " + result);        }        static void WriteResult(string description, float result)        {            // cw using formatting string where 0 is the first arg passed in and 1 is the second arg given            // Console.WriteLine("{0}: {1}", description, result);            Console.WriteLine($"{description}: {result:F2}");        }    }}