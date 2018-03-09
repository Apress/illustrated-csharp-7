using System;
using System.Reflection;   // Use the Reflection namespace to take full advantage
                           // of determining information about a type.

class SomeClass
{
}

class Program
{
   static void Main()
   {
      SomeClass s = new SomeClass();
      Console.WriteLine($"Type s: { s.GetType().Name }");
   }
}
