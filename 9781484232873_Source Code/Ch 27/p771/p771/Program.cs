using System;

class MyClass
{
   class MyCounter // Nested class
   {
      public int Count { get; private set; }

      public static MyCounter operator ++( MyCounter current )
      {
         current.Count++;
         return current;
      }
   }

   private MyCounter counter; // Field of nested class type

   public MyClass()      { counter = new MyCounter(); }     // Constructor
   public int Incr()     { return ( counter++ ).Count; }    // Increment method.
   public int GetValue() { return counter.Count; }          // Get counter value.
}

class Program
{
   static void Main()
   {
      MyClass mc = new MyClass();      // Create object.

      mc.Incr();                       // Increment it.
      mc.Incr();                       // Increment it.
      mc.Incr();                       // Increment it.
      mc.Incr();                       // Increment it.
      mc.Incr();                       // Increment it.
      mc.Incr();                       // Increment it.

      Console.WriteLine( $"Total: { mc.GetValue() }" ); // Print its value.
   }
}
