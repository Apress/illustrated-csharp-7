using System;
using System.Linq;

class Program
{
   static void Main()
   {
      int[] numbers = { 2, 5, 28, 31, 17, 16, 42 };

      var numsQuery = from n in numbers               // Query syntax
                      where n < 20
                      select n;

      var numsMethod = numbers.Where(N => N < 20);    // Method syntax

      int numsCount = (from n in numbers              // Combined
                       where n < 20
                       select n).Count();

      foreach (var x in numsQuery)
         Console.Write($"{ x }, ");
      Console.WriteLine();

      foreach (var x in numsMethod)
         Console.Write($"{ x }, ");
      Console.WriteLine();

      Console.WriteLine(numsCount);
   }
}

