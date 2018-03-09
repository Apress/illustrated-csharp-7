using System;

class Literals
{
   static void Main()
   {
      int a, b, x = 14;

      a = x << 3;    // Shift left
      b = x >> 3;    // Shift right

      Console.WriteLine($"{ x } << 3 = { a }");
      Console.WriteLine($"{ x } >> 3 = { b }");
   }
}