using System;
using System.Collections.Generic;

namespace Grades
{
    class GradeBook
    {
        // GradeBook State, for example the grades for a user.
        public GradeBook()
        {
            // The list was being instantiated as List<float>grades = new List<float>() before
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            
            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count; //careful with zeroes
            

            return stats;
        }

        // GradeBook Behavior, methods, like add a new grade, and calculate statistics
        // Use verbs, since these methods are supposed to do things

        public void AddGrade(float grade) // They asked us to use floating-points, you could use float, or double for double precision.
        {
            grades.Add(grade);
        }

        private List<float> grades; // list of floats, with the field grades, need to make sure it has been initialized as a list of floats
    }
}
