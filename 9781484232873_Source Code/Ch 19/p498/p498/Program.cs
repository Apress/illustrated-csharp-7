using System;
using System.Collections.Generic;

class MyClass
{
   public IEnumerator<string> GetEnumerator()       // Returns the enumerator
   {
      return BlackAndWhite();
   }

   public IEnumerator<string> BlackAndWhite()      // Iterator
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
         Console.WriteLine(shade);
   }
}