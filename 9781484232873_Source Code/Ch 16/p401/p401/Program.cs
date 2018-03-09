using System;

interface IDataRetrieve { int GetData(); }            // Declare interface.
interface IDataStore    { void SetData( int x ); }    // Declare interface.

class MyData : IDataRetrieve, IDataStore              // Declare class.
{
   int Mem1;                                          // Declare field.

   public int GetData()
   {
      return Mem1;
   }

   public void SetData( int x )
   {
      Mem1 = x;
   }
}

class Program
{
   static void Main()                                 // Main
   {
      MyData data = new MyData();
      data.SetData( 5 );
      Console.WriteLine( $"Value = { data.GetData() }" );
   }
}