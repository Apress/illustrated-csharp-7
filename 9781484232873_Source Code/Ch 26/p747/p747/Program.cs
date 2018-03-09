using System;

///////////////////////////////////////////////////////////////////////////////////////////
// 
// IMPORTANT:
// Notice that in the Properties section of the project, it is set to target .NET 4.7
// 
///////////////////////////////////////////////////////////////////////////////////////////
class Program
{
   static void Main()
   {
      var corvette = GetRemainingRange( .25, 24, "British" );
      Console.WriteLine( $"Remaining range is {corvette.distance} {corvette.units}" );
      var prius = GetRemainingRange( .04, 12, "Metric" );
      Console.WriteLine( $"Remaining range is {prius.distance} {prius.units}" );
   }

   // This method returns a ValueTuple.
   public static (double distance, string units) GetRemainingRange
   ( double fuelConsumptionRate, double remainingFuel, string systemOfUnits )
   {
      string units = string.Empty;
      switch ( systemOfUnits )
      {
         case "Metric":
            units = "Kilometers";
            break;

         case "British":
            units = "Miles";
            break;
      }

      //Notice that this local function has no parameters
      double CalculateRemainingRange()
      {
         return remainingFuel / fuelConsumptionRate;
      }
      return (CalculateRemainingRange(), units);
   }
}