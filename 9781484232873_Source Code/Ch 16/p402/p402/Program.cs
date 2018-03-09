using System;

interface IIfc1
{
   void PrintOut( string s );
}

interface IIfc2
{
   void PrintOut( string t );
}

class MyClass : IIfc1, IIfc2              // Implement both interfaces.
{
   public void PrintOut( string s )       // Single implementation for both
   {
      Console.WriteLine( $"Calling through:  { s }" );
   }
}

class Program
{
   static void Main()
   {
      MyClass mc = new MyClass();
      mc.PrintOut( "object" );
   }
}