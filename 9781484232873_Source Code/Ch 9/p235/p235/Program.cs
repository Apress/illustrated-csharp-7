using System;

class Literals
{
   static void Main()
   {
      int x = 5, y;
      y = x++;    // result: y: 5, x: 6
      Console.WriteLine($"y: { y }, x: { x }");

      x = 5;
      y = ++x;    // result: y: 6, x: 6
      Console.WriteLine($"y: { y }, x: { x }");

      x = 5;
      y = x--;    // result: y: 5, x: 4
      Console.WriteLine($"y: { y }, x: { x }");

      x = 5;
      y = --x;    // result: y: 4, x: 4
      Console.WriteLine($"y: { y }, x: { x }");
   }
}