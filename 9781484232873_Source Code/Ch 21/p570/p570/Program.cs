using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

class MyDownloadString
{
   Stopwatch sw = new Stopwatch();
   public void DoRun()
   {
      const int LargeNumber = 6_000_000;
      sw.Start();

      Task<int> t1 = CountCharactersAsync( 1, "http://www.microsoft.com" );
      Task<int> t2 = CountCharactersAsync( 2, "http://www.illustratedcsharp.com" );
      CountToALargeNumber( 1, LargeNumber );
      CountToALargeNumber( 2, LargeNumber );
      CountToALargeNumber( 3, LargeNumber );
      CountToALargeNumber( 4, LargeNumber );

      Console.WriteLine( "Chars in http://www.microsoft.com : {0}", t1.Result );
      Console.WriteLine( "Chars in http://www.illustratedcsharp.com: {0}", t2.Result );
   }

   private async Task<int> CountCharactersAsync( int id, string site )
   {
      WebClient wc = new WebClient();
      Console.WriteLine( "Starting call {0} : {1, 4:N0} ms",
      id, sw.Elapsed.TotalMilliseconds );

      string result = await wc.DownloadStringTaskAsync( new Uri( site ) );
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