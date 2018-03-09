using System;

class Program
{
   static void Main()
   {
      var student = new { Name = "Mary Jones", Age = 19, Major = "History" };

      Console.WriteLine($"{ student.Name }, Age { student.Age }, Major: {student.Major}");
   }
}

