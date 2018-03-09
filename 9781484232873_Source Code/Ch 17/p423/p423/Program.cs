using System;

class Program
{
   static void Main( string[] args )
   {
      byte sb;
      ushort sh = 2000;
      checked
      {
         unchecked
         {
            sb = (byte) sh;
            Console.WriteLine( $"sb: { sb }" );
         }

         sb = checked((byte) sh);
         Console.WriteLine( $"sb: { sb }" );
      }
   }
}
