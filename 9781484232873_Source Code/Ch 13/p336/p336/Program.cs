using System;

class Program
{
   static void Main( string[] args )
   {
      int[] arr1 = { 10, 11, 12, 13 };
      foreach ( int item in arr1 )
         Console.WriteLine( $"Item Value: { item }" );
   }
}

