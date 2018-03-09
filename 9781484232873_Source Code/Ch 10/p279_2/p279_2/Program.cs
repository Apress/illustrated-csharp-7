using System;

class Program
{
   static void Main()
   {
      for (int x = 1; x < 4; x++)
      {
         switch (x)
         {
            default:
               Console.WriteLine($"x is { x } -- In Default case");
               break;
         }
      }
   }
}