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
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average Grade: " + stats.AverageGrade);
            Console.WriteLine("Highest Grade: " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade:  {0}", stats.LowestGrade);

            // book.LowestGrade();

            // If I were to say something like book2 = book, it would just point to the original
            // It does not just create a new instance or copy of it.
            // GradeBook book2 = new GradeBook();
            // book2.AddGrade(75);
            // book.grades
        }
    }
}
