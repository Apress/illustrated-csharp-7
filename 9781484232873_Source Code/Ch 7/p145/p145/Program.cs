using System;

class C1
{
   private int theRealValue = 10;      // Backing Field: memory allocated

   public int MyValue                  // Property: no memory allocated
   {
      set { theRealValue = value; }    // Sets the value of field theRealValue
      get { return theRealValue; }     // Gets the value of the field
   }
}

class Program
{
   static void Main()
   {
      C1 c = new C1();
      Console.WriteLine( "MyValue: {0}", c.MyValue );

      c.MyValue = 20;
      Console.WriteLine( "MyValue: {0}", c.MyValue );
   }
}