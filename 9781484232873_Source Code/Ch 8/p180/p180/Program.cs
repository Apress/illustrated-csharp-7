using System;

class SomeClass // Base class
{
   public string Field1 = "SomeClass Field1";
   public void Method1( string value )
   {
      Console.WriteLine( $"SomeClass.Method1: { value }" );
   }
}

class OtherClass : SomeClass // Derived class
{
   new public string Field1 = "OtherClass Field1";    // Mask the base member.
   new public void Method1( string value )
   {
      Console.WriteLine( $"OtherClass.Method1: { value }" );
   }
}

class Program
{
   static void Main()
   {
      OtherClass oc = new OtherClass();               // Use the masking member.
      oc.Method1( oc.Field1 );                        // Use the masking member.
   }
}