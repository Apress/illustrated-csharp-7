using System;

class Student
{
}

class Program
{
   static void Main( string[] args )
   {
      Student[] students = null;
      int? studentCount  = 5;

      if ( students != null )                   // Checking for null before accessing
         studentCount = students.Length;        // Accessing non-null reference
      Console.WriteLine( $"studentCount: { studentCount }" );

      studentCount = students?.Length;          // Using the null conditional operator
      Console.WriteLine( $"studentCount: { studentCount }" );
   }
}
