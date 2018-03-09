using System;

class Program
{
   static void Main( string[] args )
   {
      int i = 10; // Create and initialize value type

      object oi = i; // Create and initialize reference type
      Console.WriteLine( $"i: { i }, io: { oi }" );

      i  = 12;
      oi = 15;
      Console.WriteLine( $"i: { i}, io: {oi }" );
   }
}
