using System;
using System.Threading;

delegate long MyDel( int first, int second );

class Program
{
   static long Sum( int x, int y )
   {
      Console.WriteLine( " Inside Sum" );
      Thread.Sleep( 100 );
      return x + y;
   }
   static void Main()
   {
      MyDel del = new MyDel( Sum );

      IAsyncResult iar = del.BeginInvoke( 3, 5, null, null ); // Start async.
      Console.WriteLine( "After BeginInvoke" );

      while ( !iar.IsCompleted )
      {
         Console.WriteLine( "Not Done" );
         // Continue processing, even though in this case it's just busywork.
         for ( long i = 0; i < 10_000_000; i++ )
            ; // Empty statement
      }
      Console.WriteLine( "Done" );

      long result = del.EndInvoke( iar );
      Console.WriteLine( $"Result: { result }" );
   }
}
