using System;

interface IIfc1
{
   void PrintOut( string s );
}

class MyClass : IIfc1
{
   public void PrintOut( string s )
   {
      Console.WriteLine( $"Calling through: { s }" );
   }
}

class Program
{
   static void Main()
   {
      MyClass mc = new MyClass();   // Create class object.
      mc.PrintOut( "object" );      // Call class object implementation method.

      IIfc1 ifc = (IIfc1) mc;       // Cast class object ref to interface ref.
      ifc.PrintOut( "interface" );  // Call interface method.
   }
}