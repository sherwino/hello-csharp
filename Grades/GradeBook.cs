using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        // GradeBook State, for example the grades for a user.
        public GradeBook()
        {

        }
        // GradeBook Behavior, methods, like add a new grade, and calculate statistics
        // Use verbs, since these methods are supposed to do things

        public void AddGrade(float grade) // They asked us to use floating-points, you could use float, or double for double precision.
        {
            grades.Add(grade);
        }

        List<float> grades = new List<float>(); // list of floats, with the field grades, need to make sure it has been initialized as a list of floats
    }
}
