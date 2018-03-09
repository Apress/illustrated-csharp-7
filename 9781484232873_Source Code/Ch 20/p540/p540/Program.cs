using System;
using System.Linq;

class Program
{
   static void Main()
   {
      int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };

      var countOdd   = intArray.Count(n => n % 2 == 1);

      Console.WriteLine($"Count of odd numbers: { countOdd }");
   }
}
