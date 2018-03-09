using System;

class Program
{
   [Obsolete( "Use method SuperPrintOut" )] // Apply attribute to method.
   static void PrintOut( string str )
   {
      Console.WriteLine( str );
   }

   static void Main( string[] args )
   {
      PrintOut( "Start of Main" ); // Invoke obsolete method.
   }
}