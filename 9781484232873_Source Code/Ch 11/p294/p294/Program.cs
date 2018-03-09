using System;

struct Point
{
   public int X;
   public int Y;
}

class Program
{
   static void Main()
   {
      Point first, second, third;

      first.X  = 10; first.Y = 10;
      second.X = 20; second.Y = 20;
      third.X  = first.X + second.X;
      third.Y  = first.Y + second.Y;

      Console.WriteLine($"first:   { first.X }, { first.Y }");
      Console.WriteLine($"second:  { second.X }, { second.Y }");
      Console.WriteLine($"third:   { third.X }, { third.Y }");
   }
}
