using System;
using System.Text;

class Program
{
   static void Main()
   {
      StringBuilder sb = new StringBuilder( "Hi there." );
      Console.WriteLine( $"{ sb.ToString() }" );         // Print string.

      sb.Replace( "Hi", "Hello" );                       // Replace a substring.
      Console.WriteLine( $"{ sb.ToString() }" );         // Print changed string.
   }
}