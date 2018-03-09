using System;

class Program
{
   static void Main()
   {
      int x = 2;
      ref int y = ref x;

      Console.WriteLine( $"x = {x}, y = {y}" );
      x = 5;
      Console.WriteLine( $"x = {x}, y = {y}" );
      y = 6;
      Console.WriteLine( $"x = {x}, y = {y}" );
   }
}