using System;

abstract class AbClass                       // Abstract class
{
   public void IdentifyBase()                // Normal method
   {
      Console.WriteLine( "I am AbClass" );
   }

   abstract public void IdentifyDerived();   // Abstract method
}

class DerivedClass : AbClass                 // Derived class
{
   override public void IdentifyDerived()    // Implementation of abstract method
   {
      Console.WriteLine( "I am DerivedClass" );
   }
}

class Program
{
   static void Main()
   {
      // AbClass a = new AbClass(); // Error. Cannot instantiate
      // a.IdentifyDerived(); // an abstract class.

      DerivedClass b = new DerivedClass();   // Instantiate the derived class.
      b.IdentifyBase();                      // Call the inherited method.
      b.IdentifyDerived();                   // Call the "abstract" method.
   }
}