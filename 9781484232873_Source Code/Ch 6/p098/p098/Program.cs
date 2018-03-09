using System;

class MyClass
{
   public int Val = 20; // Initialize field to 20.
}

class Program
{
   static void MyMethod( ref MyClass f1, ref int f2 )
   {
      f1.Val = f1.Val + 5; // Add 5 to field of f1 param.
      f2     = f2 + 5;     // Add 5 to second param.

      Console.WriteLine( $"f1.Val: { f1.Val }, f2: { f2 }" );
   }

   static void Main()
   {
      MyClass a1 = new MyClass();
      int a2     = 10;

      MyMethod( ref a1, ref a2 ); // Call the method.
      Console.WriteLine( $"a1.Val: { a1.Val }, a2: { a2 }" );
   }
}
