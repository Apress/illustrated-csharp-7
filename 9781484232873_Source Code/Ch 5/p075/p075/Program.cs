using System;

class DaysTemp // Declare the class
{
   public int High, Low;   // Declare the instance fields
   public int Average()    // Declare the instance method
   {
      return ( High + Low ) / 2;
   }
}

class Program
{
   static void Main()
   {
      // Create two instances of DaysTemp
      DaysTemp t1 = new DaysTemp();
      DaysTemp t2 = new DaysTemp();

      // Write to the fields of each instance
      t1.High = 76;
      t1.Low  = 57;
      t2.High = 75;
      t2.Low  = 53;

      // Read from the fields of each instance and call a method of
      // each instance
      Console.WriteLine( "t1: {0}, {1}, {2}", t1.High, t1.Low, t1.Average() );
      Console.WriteLine( "t2: {0}, {1}, {2}", t2.High, t2.Low, t2.Average() );
   }
}
