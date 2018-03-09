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
                     where a > 4 && b <= 8
                     select new { a, b, sum = a + b };

      foreach (var x in someInts)
         Console.WriteLine(x);
   }
}

