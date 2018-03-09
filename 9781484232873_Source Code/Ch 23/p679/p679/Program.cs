using System;

class Program
{
   static string SecretCode { get { return "Roses are red"; } }

   static void Main()
   {
      bool safe = false;
      try
      {
         string secretCode = safe
                     ? SecretCode
                     : throw new Exception( "Not safe to get code." );
         Console.WriteLine( $"Code is: {secretCode}." );
      }
      catch ( Exception e )
      {
         Console.WriteLine( $"{ e.Message }" );
      }
   }
}
