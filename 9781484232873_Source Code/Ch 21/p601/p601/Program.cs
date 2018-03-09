using System;
using System.Threading.Tasks;

static class DoStuff
{
   public static async Task<int> FindSeriesSum( int i1 )
   {
      int sum = 0;
      for ( int i = 0; i < i1; i++ )
      {
         sum += i;
         if ( i % 1000 == 0 )
            await Task.Yield();
      }
      return sum;
   }
}

class Program
{
   static void Main()
   {
      Task<int> value = DoStuff.FindSeriesSum( 1_000_000 );
      CountBig( 100_000 );
      CountBig( 100_000 );
      CountBig( 100_000 );
      CountBig( 100_000 );
      Console.WriteLine( $"Sum: { value.Result }" );
   }

   private static void CountBig( int p )
   {
      for ( int i = 0; i < p; i++ )
         ;
   }
}