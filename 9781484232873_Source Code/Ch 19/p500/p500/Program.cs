using System;
using System.Collections.Generic;

class MyClass
{
   public IEnumerator<string> GetEnumerator()
   {
      IEnumerable<string> myEnumerable = BlackAndWhite(); // Get enumerable.
      return myEnumerable.GetEnumerator(); // Get enumerator.
   }

   public IEnumerable<string> BlackAndWhite()
   {
      yield return "black";
      yield return "gray";
      yield return "white";
   }
}

class Program
{
   static void Main()
   {
      MyClass mc = new MyClass();

      foreach (string shade in mc)
         Console.Write($"{ shade } ");

      foreach (string shade in mc.BlackAndWhite())
         Console.Write($"{ shade } ");
   }
}
