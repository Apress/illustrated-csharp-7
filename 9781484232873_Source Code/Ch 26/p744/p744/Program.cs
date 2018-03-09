using System;

class Program
{
   static void Main( string[] args )
   {
      int transparency  = 0b11111111;
      int transparency2 = 0b11_11_11_11;
      int transparency3 = 0xff;

      Console.WriteLine( "Binary: " + transparency );
      Console.WriteLine( "Binary with separators: " + transparency2 );
      Console.WriteLine( "Hex: " + transparency3 );
   }
}
