using System;

class Program
{
   public void MethodWithLocalFunction()
   {
      int MyLocalFunction( int z1 ) // Local function declaration
      {
         return z1 * 5;
      }

      int results = MyLocalFunction( 5 ); // Call local function
      Console.WriteLine( $"Results of local function call: {results}" );
   }

   static void Main( string[] args )
   {
      Program myProgram = new Program();
      myProgram.MethodWithLocalFunction(); // Call Method
   }
}