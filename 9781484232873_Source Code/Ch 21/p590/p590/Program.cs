using System;
using System.Net;
using System.Threading.Tasks;

static class MyDownloadString
{
   public static void DoRun()
   {
      Task<int> t = CountCharactersAsync( "http://www.illustratedcsharp.com" );
      t.Wait();
      Console.WriteLine( $"The task has finished, returning value { t.Result }." );
   }

   private static async Task<int> CountCharactersAsync( string site )
   {
      string result = await new WebClient().DownloadStringTaskAsync( new Uri( site ) );
      return result.Length;
   }
}

class Program
{
   static void Main()
   {
      MyDownloadString.DoRun();
   }
}