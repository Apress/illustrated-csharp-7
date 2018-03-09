using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Simple
{
   Stopwatch sw = new Stopwatch();
   public void DoRun()
   {
      Console.WriteLine( "Caller: Before call" );
      ShowDelayAsync();
      Console.WriteLine( "Caller: After call" );
   }

   private async void ShowDelayAsync()
   {
      sw.Start();
      Console.WriteLine( $"   Before Delay: { sw.ElapsedMilliseconds }" );
      await Task.Delay( 1000 );
      Console.WriteLine( $"   After Delay : { sw.ElapsedMilliseconds }" );
   }
}

class Program
{
   static void Main()
   {
      Simple ds = new Simple();
      ds.DoRun();
      Console.Read();
   }
}
