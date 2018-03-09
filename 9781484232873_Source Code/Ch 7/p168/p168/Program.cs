using System;

class Class1
{
   int Temp0;                    // Private field
   int Temp1;                    // Private field

   public int this[int index]    // The indexer
   {
      get
      {
         return ( 0 == index )   // Return value of either Temp0 or Temp1
                     ? Temp0
                     : Temp1;
      }
      set
      {
         if ( 0 == index )
            Temp0 = value;       // Note the implicit variable "value".
         else
            Temp1 = value;       // Note the implicit variable "value".
      }
   }
}
class Example
{
   static void Main()
   {
      Class1 a = new Class1();

      Console.WriteLine( "Values -- T0: {0}, T1: {1}", a[0], a[1] );
      a[0] = 15;
      a[1] = 20;
      Console.WriteLine( $"Values -- T0: { a[0] }, T1: { a[1] }" );
   }
}
