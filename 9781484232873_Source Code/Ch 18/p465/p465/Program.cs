using System;

class Simple                                          // Non-generic class
{
   static public void ReverseAndPrint<T>(T[] arr)     // Generic method
   {
      Array.Reverse(arr);
      foreach (T item in arr) // Use type argument T.
         Console.Write($"{ item.ToString() }, ");
      Console.WriteLine("");
   }
}

class Program
{
   static void Main()
   {
      // Create arrays of various types.
      var intArray = new int[] { 3, 5, 7, 9, 11 };
      var stringArray = new string[] { "first", "second", "third" };
      var doubleArray = new double[] { 3.567, 7.891, 2.345 };

      Simple.ReverseAndPrint<int>(intArray);          // Invoke method.
      Simple.ReverseAndPrint(intArray);               // Infer type and invoke.

      Simple.ReverseAndPrint<string>(stringArray);    // Invoke method.
      Simple.ReverseAndPrint(stringArray);            // Infer type and invoke.

      Simple.ReverseAndPrint<double>(doubleArray);    // Invoke method.
      Simple.ReverseAndPrint(doubleArray);            // Infer type and invoke.
   }
}