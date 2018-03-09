using System;
using System.Runtime.Remoting.Messaging; // To access the AsyncResult type
using System.Threading;

delegate long MyDel( int first, int second );

class Program
{
   static long Sum( int x, int y )
   {
      Console.WriteLine( "                    Inside Sum" );
      Thread.Sleep( 100 );
      return x + y;
   }

   static void CallWhenDone( IAsyncResult iar )
   {
      Console.WriteLine( "                    Inside CallWhenDone." );
      AsyncResult ar = (AsyncResult) iar;
      MyDel del = (MyDel) ar.AsyncDelegate;

      long result = del.EndInvoke( iar );
      Console.WriteLine( "                    The result is: {0}.", result );
   }

   static void Main()
   {
      MyDel del = new MyDel( Sum );

      Console.WriteLine( "Before BeginInvoke" );
      IAsyncResult iar =
            del.BeginInvoke( 3, 5, new AsyncCallback( CallWhenDone ), null );

      Console.WriteLine( "Doing more work in Main." );
      Thread.Sleep( 500 );
      Console.WriteLine( "Done with Main. Exiting." );
   }
}