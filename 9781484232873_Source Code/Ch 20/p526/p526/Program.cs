using System;
using System.Linq;

namespace p526
{
   class Program
   {
      static void Main()
      {
         var students = new[] // Array of objects of an anonymous type
         {
            new { LName="Jones",  FName="Mary",   Age=19, Major="History" },
            new { LName="Smith",  FName="Bob",    Age=20, Major="CompSci" },
            new { LName="Fleming", FName="Carol", Age=21, Major="History" }
         };
         var query = from student in students
                     orderby student.Age
                     select student;

         foreach (var s in query)
         {
            Console.WriteLine($"{ s.LName }, { s.FName }: { s.Age }, { s.Major }");
         }
      }
   }
}
