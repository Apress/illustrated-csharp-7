using System;

class SomeClass                                          // Base class
{
   public string Field1 = "Field1 -- In the base class";
}

class OtherClass : SomeClass                             // Derived class
{
   new public string Field1= "Field1 -- In the derived class";
   public void PrintField1()
   {
      Console.WriteLine( Field1 );                       // Access the derived class.
      Console.WriteLine( base.Field1 );                  // Access the base class.
   }
}

class Program
{
   static void Main()
   {
      OtherClass oc = new OtherClass();
      oc.PrintField1();
   }
}