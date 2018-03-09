using System;
using System.Collections;

class Program
{
   static void Main()
   {
      int[] arr1 = { 10, 11, 12, 13 };                         // Create an array.

      IEnumerator ie = arr1.GetEnumerator();

      while (ie.MoveNext())
      {
         int item = (int)ie.Current;
         Console.WriteLine($"Item value: { item }");           // Write it out.
      }
   }
}

