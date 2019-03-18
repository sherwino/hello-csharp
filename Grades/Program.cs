using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // GradeBook book; can also be used but it won't actually be an object I could do anything with
            GradeBook book = new GradeBook(); // Variable of type gradebook, using a constructor. Init memory

            // Now the variable I declared should have all of the methods avaialble to the Gradebook, any integer value will convert to a float
            book.AddGrade(91);
            // If you type 89.5 it considers it a double float by default. So you might have to explicitely tell it is a float with "f"
            book.AddGrade(89.5f); // this is a 
        }
    }
}
