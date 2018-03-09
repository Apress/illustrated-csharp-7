using System;
using System.Collections.Generic;
using System.Linq;

class Program
   {
   static void Main()
   {
      int[] numbers = { 2, 12, 5, 15 };         // Data source
      IEnumerable<int> lowNums =                // Define and store the query.
                           from n in numbers
                           where n < 10
                           select n;

      foreach (var x in lowNums)                // Execute the query.
         Console.Write($"{ x }, ");
   }
}

