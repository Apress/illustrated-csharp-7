using System;

class Program
{
   static void Main(string[] args)
   {
      int[] arr1 = { 10, 11, 12, 13 };                // Define the array.

      foreach (int item in arr1)                      // Enumerate the elements.
         Console.WriteLine($"Item value: { item }");
   }
}

