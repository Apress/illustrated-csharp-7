using System;

class D
{
   int        Mem1;
   static int Mem2;

   public void SetVars( int v1, int v2 )     // Set the values
   {
      Mem1 = v1;
      Mem2 = v2;
   }

   public void Display( string str )
   {
      Console.WriteLine( "{0}: Mem1= {1}, Mem2= {2}", str, Mem1, Mem2 );
   }
}

class Program
{
   static void Main()
   {
      D d1 = new D(), d2 = new D();          // Create two instances.
      d1.SetVars( 2, 4 );                    // Set d1's values.
      d1.Display( "d1" );

      d2.SetVars( 15, 17 );                  // Set d2's values.
      d2.Display( "d2" );

      d1.Display( "d1" );                    // Display d1 again and notice that the
   }                                         // value of static member Mem2 has changed!
}