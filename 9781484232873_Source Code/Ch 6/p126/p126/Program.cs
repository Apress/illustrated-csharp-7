using System;

class Program
{
   public void Count( int inVal )
   {
      if ( inVal == 0 )
         return;
      Count( inVal - 1 );              // Invoke this method again.

      Console.WriteLine( $"{ inVal }" );
   }

   static void Main()
   {
      Program pr = new Program();
      pr.Count( 3 );
   }
}