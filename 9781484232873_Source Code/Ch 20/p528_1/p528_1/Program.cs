using System;
using System.Linq;

class Program
{
   static void Main()
   {
      var students = new[]                      // Array of objects of an anonymous type
      {
         new { LName="Jones",   FName="Mary",  Age=19, Major="History" },
         new { LName="Smith",   FName="Bob",   Age=20, Major="CompSci" },
         new { LName="Fleming", FName="Carol", Age=21, Major="History" }
      };

      var query = from s in students
                  select s;

      foreach (var q in query)
         Console.WriteLine($"{ q.LName }, { q.FName }: { q.Age }, { q.Major }");
   }
}