using System;

class Program
{
   static void Main( string[] args )
   {
      string s = "Hi there.";
      Console.WriteLine( $"{ s.ToUpper() }" ); // Print uppercase copy
      Console.WriteLine( $"{ s }" ); // String is unchanged
   }
}
