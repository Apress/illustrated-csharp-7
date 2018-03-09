using System;
using System.Threading; // For Thread.Sleep()

delegate long MyDel( int first, int second );   // Declare delegate type.

class Program
{
   static long Sum( int x, int y )              // Declare method for async.
   {
      Console.WriteLine( "                  Inside Sum" );
      Thread.Sleep( 100 );

      return x + y;
   }

   static void Main()
   {
      MyDel del = new MyDel( Sum );

      Console.WriteLine( "Before BeginInvoke" );
      IAsyncResult iar = del.BeginInvoke( 3, 5, null, null ); // Start async
      Console.WriteLine( "After  BeginInvoke" );

      Console.WriteLine( "Doing stuff" );

      long result = del.EndInvoke( iar );       // Wait for end and get result
      Console.WriteLine( $"After  EndInvoke: { result }" );
   }
}