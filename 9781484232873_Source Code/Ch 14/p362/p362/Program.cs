using System;

delegate void MyDel( ref int X );

class MyClass
{
   public void Add2( ref int x ) { x += 2; }
   public void Add3( ref int x ) { x += 3; }

   static void Main()
   {
      MyClass mc = new MyClass();

      MyDel mDel = mc.Add2;
      mDel += mc.Add3;
      mDel += mc.Add2;

      int x = 5;
      mDel( ref x );

      Console.WriteLine( $"Value: { x }" );
   }
}