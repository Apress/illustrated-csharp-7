using System;

interface IIfc1                        // Declare interface.
{
void PrintOut( string s );
}

class MyClass : IIfc1                  // Declare class.
{
   public void PrintOut( string s )    // Implementation
   {
      Console.WriteLine( $"Calling through: { s }" );
   }
}

class Program
{
   static void Main()
   {
      MyClass mc = new MyClass(); // Create instance.
      mc.PrintOut( "object" ); // Call method.
   }
}