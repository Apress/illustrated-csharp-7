using System;

class Program
{
   static void Main()
   {
      for (int x = 1; x < 6; x++)
      {
         switch (x)                          // Evaluate the value of variable x.
         {
            case 2:                                            // If x equals 2
               Console.WriteLine($"x is { x } -- In Case 2");
               break; // Go to end of switch.

            case 5:                                            // If x equals 5
               Console.WriteLine($"x is { x } -- In Case 5");
               break; // Go to end of switch.

            default:                                           // If x is neither 2 nor 5
               Console.WriteLine($"x is { x } -- In Default case");
               break; // Go to end of switch.
         }
      }
   }
}
