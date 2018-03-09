using System;

class Program
{
   static void Main(string[] args)
   {
      // The body of this for loop is executed three times.
      for (int i = 0; i < 3; i++)
         Console.WriteLine($"Inside loop. i: { i }");

      Console.WriteLine("Out of Loop");
   }
}
