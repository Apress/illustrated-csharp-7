using System;

delegate double MyDel( int par );

class Program
{
   static void Main()
   {
      MyDel del = delegate ( int x ) { return x + 1; };  // Anonymous method

      MyDel le1 = ( int x ) => { return x + 1; };        // Lambda expression
      MyDel le2 =     ( x ) => { return x + 1; };
      MyDel le3 =         x => { return x + 1; };
      MyDel le4 =         x => x + 1;

      Console.WriteLine( $"{ del( 12 ) }" );
      Console.WriteLine( $"{ le1( 12 ) }" );
      Console.WriteLine( $"{ le2( 12 ) }" );
      Console.WriteLine( $"{ le3( 12 ) }" );
      Console.WriteLine( $"{ le4( 12 ) }" );
   }
}