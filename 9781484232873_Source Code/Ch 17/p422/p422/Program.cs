using System;

class Program
{
   static void Main( string[] args )
   {
      ushort sh = 2000;
      byte sb;

      sb = unchecked((byte) sh);             // Most significant bits lost
      Console.WriteLine( $"sb: { sb }" );

      sb = checked((byte) sh);               // OverflowException raised
      Console.WriteLine( $"sb: { sb }" );
   }
}
