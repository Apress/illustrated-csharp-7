using System;
using System.Threading.Tasks;

class Program
{
   static void Main( string[] args )
   {
      Task t = BadAsync();
      t.Wait();
      Console.WriteLine( $"Task Status : { t.Status }" );
      Console.WriteLine( $"Task IsFaulted: { t.IsFaulted }" );
   }

   static async Task BadAsync()
   {
      try
      {
         await Task.Run( () => { throw new Exception(); } );
      }
      catch
      {
         Console.WriteLine( "Exception in BadAsync" );
      }
   }
}