using System;

class Program
{
   static void Main( string[] args )
   {
      int myInt = 500;

      Console.WriteLine( "|{0, 10}|", myInt ); // Aligned right
      Console.WriteLine( "|{0,-10}|", myInt ); // Aligned left
   }
}
