using static System.Console;

class Program
{
   static ref int Max( ref int p1, ref int p2 )
   {
      if ( p1 > p2 )
         return ref p1; // Return the reference--not the value.
      else
         return ref p2; // Return the reference--not the value.
   }
   static void Main()
   {
      int v1 = 10;
      int v2 = 20;
      WriteLine( "Start" );
      WriteLine( $"v1: {v1}, v2: {v2}\n" );

      ref int max = ref Max( ref v1, ref v2 );
      WriteLine( "After assignment" );
      WriteLine( $"max: {max}\n" );

      max++;
      WriteLine( "After increment" );
      WriteLine( $"max: {max}, v1: {v1}, v2: {v2}" );
   }
}