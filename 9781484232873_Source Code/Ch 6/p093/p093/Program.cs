using System;

class MyClass
{
   public int Sum( int x, int y )                  // Declare the method.
   {
      return x + y;                                // Return the sum.
   }

   public float Avg( float input1, float input2 )  // Declare the method.
   {
      return ( input1 + input2 ) / 2.0F;           // Return the average.
   }
}

class Program
{
   static void Main()
   {
      MyClass myT = new MyClass();
      int someInt = 6;

      Console.WriteLine( "Newsflash: Sum: {0} and {1} is {2}", 5, someInt, myT.Sum( 5, someInt ) ); // Invoke the method.
      Console.WriteLine( "Newsflash: Avg: {0} and {1} is {2}", 5, someInt, myT.Avg( 5, someInt ) ); // Invoke the method.
   }
}