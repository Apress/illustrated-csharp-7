using System;

class SomeClass // Base class
{
   public string Field1 = "base class field ";
   public void Method1( string value )
   {
      Console.WriteLine( $"Base class -- Method1: { value }" );
   }
}

class OtherClass : SomeClass
{ // Derived class
   public string Field2 = "derived class field";
   public void Method2( string value )
   {
      Console.WriteLine( $"Derived class -- Method2: { value }" );
   }
}

class Program
{
   static void Main()
   {
      OtherClass oc = new OtherClass();
      oc.Method1( oc.Field1 ); // Base method with base field
      oc.Method1( oc.Field2 ); // Base method with derived field
      oc.Method2( oc.Field1 ); // Derived method with base field
      oc.Method2( oc.Field2 ); // Derived method with derived field
   }
}