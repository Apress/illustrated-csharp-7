using System;

class MyClass
{
   public int MyField = 0;
}

class Program
{
   static void Main()
   {
      MyClass[] mcArray = new MyClass[4];             // Create array.
      for ( int i = 0; i < 4; i++ )
      {
         mcArray[i] = new MyClass();                  // Create class objects.
         mcArray[i].MyField = i;                      // Set field.
      }

      foreach ( MyClass item in mcArray )
         item.MyField += 10;                          // Change the data.

      foreach ( MyClass item in mcArray )
         Console.WriteLine( $"{ item.MyField }" );    // Read the changed data.
   }
}