using System;

class Program
{
   static void Main( string[] args )
   {
      int inVal = 5;

      try
      {
         if ( inVal < 10 )
         {
            Console.Write( "First Branch - " );
            return;
         }
         else
            Console.Write( "Second Branch - " );
      }
      finally
      {
         Console.WriteLine( "In finally statement" );
      }
   }
}

