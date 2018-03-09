using System;

class Program
{
   static void Main( string[] args )
   {
      double myDouble = 12.345678;

      Console.WriteLine( $"{myDouble,-10:G} -- General" );
      Console.WriteLine( $"{myDouble,-10} -- Default, same as General" );
      Console.WriteLine( $"{myDouble,-10:F4} -- Fixed Point, 4 dec places" );
      Console.WriteLine( $"{myDouble,-10:C} -- Currency" );
      Console.WriteLine( $"{myDouble,-10:E3} -- Sci. Notation, 3 dec places" );
      Console.WriteLine( $"{1194719,-10:x} -- Hexadecimal integer" );
   }
}
