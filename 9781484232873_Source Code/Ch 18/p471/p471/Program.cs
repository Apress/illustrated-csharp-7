using System;

interface IMyIfc<T>                 // Generic interface
{
   T ReturnIt(T inValue);
}

class Simple<S> : IMyIfc<S>         // Generic class
{
   public S ReturnIt(S inValue)     // Implement generic interface.
   {
      return inValue;
   }
}

class Program
{
   static void Main()
   {
      var trivInt    = new Simple<int>();
      var trivString = new Simple<string>();

      Console.WriteLine($"{ trivInt.ReturnIt(5) }");
      Console.WriteLine($"{ trivString.ReturnIt("Hi there.") }");
   }
}