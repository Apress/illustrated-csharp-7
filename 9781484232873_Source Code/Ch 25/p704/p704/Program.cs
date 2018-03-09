using System;
using System.Runtime.CompilerServices;

public static class Program
{
   public static void MyTrace( string message,
                              [CallerFilePath]        string fileName = "",
                              [CallerLineNumber]       int lineNumber = 0,
                              [CallerMemberName] string callingMember = "" )
   {
      Console.WriteLine( $"File: { fileName }" );
      Console.WriteLine( $"Line: { lineNumber }" );
      Console.WriteLine( $"Called From: { callingMember }" );
      Console.WriteLine( $"Message: { message }" );
   }

   public static void Main()
   {
      MyTrace( "Simple message" );
   }
}