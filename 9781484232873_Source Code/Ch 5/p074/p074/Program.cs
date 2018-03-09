using System;

class DaysTemp // Declare class DaysTemp
{
   public int High = 75;
   public int Low = 45;
}
class Program // Declare class Program
{
   static void Main()
   {
      DaysTemp temp = new DaysTemp();              // Create the object

      temp.High = 85;                              // Assign to the fields
      temp.Low = 60;

      Console.WriteLine( "High: {0}", temp.High ); // Read from fields
      Console.WriteLine( $"Low:  { temp.Low }" );
   }
}
