using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

class MyDownloadString
{
   public void DoRun()
   {
      Task<int> t = CountCharactersAsync( "http://www.microsoft.com", "http://www.illustratedcsharp.com" );
      Console.WriteLine( "DoRun: Task {0}Finished", t.IsCompleted ? "" : "Not " );
      Console.WriteLine( "DoRun: Result = {0}", t.Result );
   }

   private async Task<int> CountCharactersAsync( string site1, string site2 )
   {
      WebClient wc1 = new WebClient();
      WebClient wc2 = new WebClient();
      Task<string> t1 = wc1.DownloadStringTaskAsync( new Uri( site1 ) );
      Task<string> t2 = wc2.DownloadStringTaskAsync( new Uri( site2 ) );

      List<Task<string>> tasks = new List<Task<string>>();
      tasks.Add( t1 );
      tasks.Add( t2 );

      await Task.WhenAll( tasks );

      Console.WriteLine( " CCA: T1 {0}Finished", t1.IsCompleted ? "" : "Not " );
      Console.WriteLine( " CCA: T2 {0}Finished", t2.IsCompleted ? "" : "Not " );

      return t1.IsCompleted ? t1.Result.Length : t2.Result.Length;
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