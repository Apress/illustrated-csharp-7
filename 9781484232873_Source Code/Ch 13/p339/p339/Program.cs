using System;

class Program
{
   static void Main()
   {
      int total    = 0;
      int[][] arr1 = new int[2][];
      arr1[0]      = new int[] { 10, 11 };
      arr1[1]      = new int[] { 12, 13, 14 };

      foreach ( int[] array in arr1 )           // Process the top level.
      {
         Console.WriteLine( "Starting new array" );
         foreach ( int item in array )          // Process the second level.
         {
            total += item;
            Console.WriteLine( $" Item: { item }, Current Total: { total }" );
         }
      }
   }
}