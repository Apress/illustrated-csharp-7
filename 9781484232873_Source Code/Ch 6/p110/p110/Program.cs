using System;

class MyClass
{
   public void ListInts( params int[] inVals )
   {
      if ( ( inVals != null ) && ( inVals.Length != 0 ) )
         for ( int i = 0; i < inVals.Length; i++ ) // Process the array.
         {
            inVals[i] = inVals[i] * 10;
            Console.WriteLine( $"{ inVals[i] }" ); // Display new value.
         }
   }
}

class Program
{
   static void Main()
   {
      int first = 5, second = 6, third = 7;        // Declare three ints.

      MyClass mc = new MyClass();
      mc.ListInts( first, second, third );         // Call the method.

      Console.WriteLine( $"{ first }, { second }, { third }" );
   }
}