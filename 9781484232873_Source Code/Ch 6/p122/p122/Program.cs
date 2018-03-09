using System;

class MyClass
{
   public int Calc( int a = 2, int b = 3, int c = 4 )
   {
      return ( a + b ) * c;
   }

   static void Main()
   {
      MyClass mc = new MyClass();
      int r0 = mc.Calc( 5, 6, 7 );  // Use all explicit values.
      int r1 = mc.Calc( 5, 6 );     // Use default for c.
      int r2 = mc.Calc( 5 );        // Use default for b and c.
      int r3 = mc.Calc();           // Use all defaults.

      Console.WriteLine( $"{r0}, {r1}, {r2}, {r3}" );
   }
}