using System;

class MyClass : IComparable                  // Class implements interface.
{
   public int TheValue;
   public int CompareTo( object obj )        // Implement the method.
   {
      MyClass mc = (MyClass) obj;

      if ( this.TheValue < mc.TheValue )
         return -1;
      if ( this.TheValue > mc.TheValue )
         return 1;

      return 0;
   }
}

class Program
{
   static void PrintOut( string s, MyClass[] mc )
   {
      Console.Write( s );
      foreach ( var m in mc )
         Console.Write( $"{ m.TheValue } " );

      Console.WriteLine( "" );
   }
   static void Main()
   {
      var myInt = new[] { 20, 4, 16, 9, 2 };

      MyClass[] mcArr = new MyClass[5];      // Create array of MyClass objs.
      for ( int i = 0; i < 5; i++ )          // Initialize the array.
      {
         mcArr[i] = new MyClass();
         mcArr[i].TheValue = myInt[i];
      }

      PrintOut( "Initial Order:  ", mcArr ); // Print the initial array.

      Array.Sort( mcArr );                   // Sort the array.
      PrintOut( "Sorted Order:   ", mcArr ); // Print the sorted array.
   }
}