using System;

delegate void MyDel( int value );            // Declare delegate TYPE.

class Program
{
   void PrintLow( int value )
   {
      Console.WriteLine( $"{ value } - Low Value" );
   }

   void PrintHigh( int value )
   {
      Console.WriteLine( $"{ value } - High Value" );
   }

   static void Main()
   {
      Program program = new Program();
      MyDel del;                             // Declare delegate variable.

      // Create random-integer-generator object and get a random
      // number between 0 and 99.
      Random rand = new Random();
      int randomValue = rand.Next( 99 );

      // Create a delegate object that contains either PrintLow or
      // PrintHigh, and assign the object to the del variable.
      del = randomValue < 50
               ? new MyDel( program.PrintLow )
               : new MyDel( program.PrintHigh );

      del( randomValue );        // Execute the delegate.
   }
}