using System;

delegate int MyDel();               // Declare delegate with return value.

class MyClass
{
   int IntValue = 5;
   public int Add2() { IntValue += 2; return IntValue; }
   public int Add3() { IntValue += 3; return IntValue; }
}

class Program
{
   static void Main()
   {
      MyClass mc = new MyClass();

      MyDel mDel = mc.Add2;         // Create and initialize the delegate.
      mDel += mc.Add3;              // Add a method.
      mDel += mc.Add2;              // Add a method.

      Console.WriteLine( $"Value: { mDel() }" );
   }
}