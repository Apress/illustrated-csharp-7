using System;

class Program
{
   static void Main( string[] args )
   {
      int? i1 = null, i2 = null;             // Both are null.

      if ( i1 == i2 )                        // Operator returns true.
         Console.WriteLine( "Equal" );
   }
}
