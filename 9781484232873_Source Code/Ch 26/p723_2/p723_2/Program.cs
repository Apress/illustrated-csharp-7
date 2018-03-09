using System;

class Program
{
   static void Main( string[] args )
   {
      string name = "Aiden";
      string technology = "Cold Fusion";
      string s;

      s = String.Format( "{0} is working on {1}.", name, technology );
      Console.WriteLine( s );

      s = String.Format( $"{ name } is working on { technology }." );
      Console.WriteLine( s );
   }
}
