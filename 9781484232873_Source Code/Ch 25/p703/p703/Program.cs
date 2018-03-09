#define DoTrace
using System;
using System.Diagnostics;

namespace AttributesConditional
{
   class Program
   {
      [Conditional( "DoTrace" )]
      static void TraceMessage( string str )
      {
         Console.WriteLine( str );
      }

      static void Main()
      {
         TraceMessage( "Start of Main" );
         Console.WriteLine( "Doing work in Main." );
         TraceMessage( "End of Main" );
      }
   }
}