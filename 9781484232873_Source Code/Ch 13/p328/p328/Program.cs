using System;

class Program
{
   static void Main( string[] args )
   {
      // Declare, create, and initialize an implicitly typed array.
      var arr = new int[,] { { 0, 1, 2 }, { 10, 11, 12 } };

      // Print the values.
      for ( int i = 0; i < 2; i++ )
         for ( int j = 0; j < 3; j++ )
            Console.WriteLine( $"Element [{ i },{ j }] is { arr[i, j] }" );
   }
}
