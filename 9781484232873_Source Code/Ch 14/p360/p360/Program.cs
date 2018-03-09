using System;

// Define a delegate type with no return value and no parameters.
delegate void PrintFunction();

class Test
{
   public void Print1()
   {
      Console.WriteLine( "Print1 -- instance" );
   }

   public static void Print2()
   {
      Console.WriteLine( "Print2 -- static" );
   }
}

class Program
{
   static void Main()
   {
      Test t = new Test();       // Create a test class instance.
      PrintFunction pf;          // Create a null delegate.

      pf = t.Print1;             // Instantiate and initialize the delegate.

      // Add three more methods to the delegate.
      pf += Test.Print2;
      pf += t.Print1;
      pf += Test.Print2;         // The delegate now contains four methods.

      if ( null != pf )          // Make sure the delegate isn't null.
         pf();                   // Invoke the delegate.
      else
         Console.WriteLine( "Delegate is empty" );
   }
}
