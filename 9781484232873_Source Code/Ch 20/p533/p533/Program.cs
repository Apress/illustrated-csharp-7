using System;
using System.Linq;

class Program
{
   static int[] numbers = new int[] { 2, 4, 6 };

   static void Main()
   {
      int total = numbers.Sum();
      int howMany = numbers.Count();

      Console.WriteLine($"Total: { total }, Count: { howMany }");
   }
}
