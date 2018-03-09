using System;

class Program
{
   static void Main()
   {
      for (int x = 1; x < 6; x++)
      {
         switch (x)
         {
            case 5:
               Console.WriteLine($"x is { x } -- In Case 5");
               break;
         }
      }
   }
}