using System;

abstract class MyBase // Combination of abstract and nonabstract members
{
   public int SideLength       = 10;               // Data member
   const int TriangleSideCount = 3;                // Data member

   abstract public void PrintStuff( string s );    // Abstract method
   abstract public int MyInt { get; set; }         // Abstract property

   public int PerimeterLength()                    // Regular, nonabstract method
   {
      return TriangleSideCount * SideLength;
   }
}

class MyClass : MyBase
{
   public override void PrintStuff( string s )     // Override abstract method
   {
      Console.WriteLine( s );
   }

   private int _myInt;
   public override int MyInt                       // Override abstract property
   {
      get { return _myInt; }
      set { _myInt = value; }
   }
}

class Program
{
   static void Main( string[] args )
   {
      MyClass mc = new MyClass();
      mc.PrintStuff( "This is a string." );
      mc.MyInt = 28;
      Console.WriteLine( mc.MyInt );
      Console.WriteLine( $"Perimeter Length: { mc.PerimeterLength() }" );
   }
}