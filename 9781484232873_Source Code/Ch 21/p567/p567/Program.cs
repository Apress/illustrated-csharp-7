using System;
using System.Net;
using System.Diagnostics;

class MyDownloadString
{
   Stopwatch sw = new Stopwatch();
   public void DoRun()
   {
      const int LargeNumber = 6_000_000;
      sw.Start();
      int t1 = CountCharacters( 1, "http://www.microsoft.com" );
      int t2 = CountCharacters( 2, "http://www.illustratedcsharp.com" );

      CountToALargeNumber( 1, LargeNumber );
      CountToALargeNumber( 2, LargeNumber );
      CountToALargeNumber( 3, LargeNumber );
      CountToALargeNumber( 4, LargeNumber );

      Console.WriteLine( $"Chars in http://www.microsoft.com : { t1 }" );
      Console.WriteLine( $"Chars in http://www.illustratedcsharp.com: { t2 }" );
   }

   private int CountCharacters( int id, string uriString )
   {
      WebClient wc1 = new WebClient();
      Console.WriteLine( "Starting call {0} : {1, 4:N0} ms",
      id, sw.Elapsed.TotalMilliseconds );
      string result = wc1.DownloadString( new Uri( uriString ) );
      Console.WriteLine( " Call {0} completed: {1, 4:N0} ms",
      id, sw.Elapsed.TotalMilliseconds );
      return result.Length;
   }

   private void CountToALargeNumber( int id, int value )
   {
      for ( long i = 0; i < value; i++ )
         ;
      Console.WriteLine( " End counting {0} : {1, 4:N0} ms",
      id, sw.Elapsed.TotalMilliseconds );
   }
}

class Program
{
   static void Main()
   {
      MyDownloadString ds = new MyDownloadString();
      ds.DoRun();
   }
}