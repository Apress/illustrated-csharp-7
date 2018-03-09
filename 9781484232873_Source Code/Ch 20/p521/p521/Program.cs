using System;
using System.Linq;

class Program
{
   // Declare classes.
   public class Student
   {
      public int StID;
      public string LastName;
   }

   public class CourseStudent
   {
      public string CourseName;
      public int StID;
   }

   static Student[] students = new Student[] {
      new Student { StID = 1, LastName = "Carson" },
      new Student { StID = 2, LastName = "Klassen" },
      new Student { StID = 3, LastName = "Fleming" },
   };

   // Initialize arrays.
   static CourseStudent[] studentsInCourses = new CourseStudent[] {
      new CourseStudent { CourseName = "Art", StID = 1 },
      new CourseStudent { CourseName = "Art", StID = 2 },
      new CourseStudent { CourseName = "History", StID = 1 },
      new CourseStudent { CourseName = "History", StID = 3 },
      new CourseStudent { CourseName = "Physics", StID = 3 },
   };

   static void Main()
   {
      // Find the last names of the students taking history.
      var query = from s in students
                  join c in studentsInCourses on s.StID equals c.StID
                  where c.CourseName == "History"
                  select s.LastName;

      // Display the names of the students taking history.
      foreach (var q in query)
         Console.WriteLine($"Student taking History: { q }");
   }
}