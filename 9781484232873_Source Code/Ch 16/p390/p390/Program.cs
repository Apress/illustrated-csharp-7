using System;

class Program
{
   static void Main( string[] args )
   {
      var myInt = new[] { 20, 4, 16, 9, 2 };    // Create an array of ints.

      Array.Sort( myInt );                      // Sort elements by magnitude.

      foreach ( var i in myInt )                // Print them out.
         Console.Write( $"{ i } " );
   }
}
