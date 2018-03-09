using System;

class Program
   {
   public static void PrintArray( int[] a )
   {
      foreach ( var x in a )
         Console.Write( $"{ x }  ");
      Console.WriteLine( "" );
   }

   static void Main()
   {
      int[] arr = new int[] { 15, 20, 5, 25, 10 };
      PrintArray( arr );

      Array.Sort( arr );
      PrintArray( arr );

      Array.Reverse( arr );
      PrintArray( arr );

      Console.WriteLine();
      Console.WriteLine( $"Rank = { arr.Rank }, Length = { arr.Length }" );
      Console.WriteLine( $"GetLength(0)     = { arr.GetLength( 0 ) }" );
      Console.WriteLine( $"GetType()        = { arr.GetType() }" );
   }
}

