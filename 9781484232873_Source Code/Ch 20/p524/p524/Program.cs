using System;
using System.Linq;

class Program
{
   static void Main()
   {
      var groupA = new[] { 3, 4, 5, 6 };
      var groupB = new[] { 6, 7, 8, 9 };

      var someInts = from a in groupA
                     from b in groupB
                     let sum = a + b
                     where sum == 12
                     select new { a, b, sum };

      foreach (var a in someInts)
         Console.WriteLine(a);
   }
}
