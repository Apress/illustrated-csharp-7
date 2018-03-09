using System;
using System.Linq;

class Program
{
   static bool IsOdd(int x)                                    // Method to be used by the delegate object
   {
      return x % 2 == 1;                                       // Return true if x is odd.
   }

   static void Main()
   {
      int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };

      Func<int, bool> myDel = new Func<int, bool>(IsOdd);      // Delegate object
      var countOdd = intArray.Count(myDel);                    // Use delegate.

      Console.WriteLine($"Count of odd numbers: { countOdd }");
   }
}
