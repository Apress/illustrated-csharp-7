using System;

class Program
{
   static void Main(string[] args)
   {
      int x = 0;
      do
         Console.WriteLine($"x is {x++ }");
      while (x < 3);
   }
}
