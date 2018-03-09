using System;

class MyClass
{
   public int Val = 20; // Initialize field to 20.
}

class Program
{
   static void MyMethod( out MyClass f1, out int f2 )
   {
      f1 = new MyClass(); // Create an object of the class.
      f1.Val = 25; // Assign to the class field.
      f2 = 15; // Assign to the int param.
   }

   static void Main()
   {
      MyMethod( out MyClass a1, out int a2 );   // Call the method.
      Console.WriteLine( a2 );                  // Use the return value

      a2 += 5;                                  // Write to the variable
      Console.WriteLine( a2 );
   }
}