using System;

interface IIfc1 { void PrintOut( string s ); }        // Declare interface.
interface IIfc2 { void PrintOut( string t ); }        // Declare interface.

class MyClass : IIfc1, IIfc2
{
   void IIfc1.PrintOut( string s )                    // Explicit interface member implementation
   {
      Console.WriteLine( $"IIfc1: { s }" );
   }

   void IIfc2.PrintOut( string s )                    // Explicit interface member implementation
   {
      Console.WriteLine( $"IIfc2: { s }" );
   }
}

class Program
{
   static void Main()
   {
      MyClass mc = new MyClass();                     // Create class object.

      IIfc1 ifc1 = (IIfc1) mc;                        // Get reference to IIfc1.
      ifc1.PrintOut( "interface 1" );                 // Call explicit implementation.

      IIfc2 ifc2 = (IIfc2) mc;                        // Get reference to IIfc2.
      ifc2.PrintOut( "interface 2" );                 // Call explicit implementation.
   }
}