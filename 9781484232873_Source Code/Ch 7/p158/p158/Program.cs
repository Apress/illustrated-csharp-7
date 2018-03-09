using System;

public class Point
{
   public int X = 1;
   public int Y = 2;
}

class Program
{
   static void Main()
   {
      Point pt1 = new Point();
      Point pt2 = new Point { X = 5, Y = 6 };

      Console.WriteLine( "pt1: {0}, {1}", pt1.X, pt1.Y );
      Console.WriteLine( $"pt2: { pt2.X }, { pt2.Y }" );
   }
}