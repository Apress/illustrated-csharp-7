using System;

class GlobalTemp
{
   public ( double d1960, double d1970, double d1980,
            double d1990, double d2000, double d2010)
   TempDifferenceUsingValueTupleCtor()
   {
      // Using the constructor
      return new ValueTuple<double, double, double, double, double, double>( 0.03, 0.00, 0.20, 0.34, 0.52, 0.63 );
   }

   public (double d1960, double d1970, double d1980, double d1990, double d2000, double d2010) TempDifferenceUsingValueTuple()
   {
      // Implicit creation
      return (0.03, 0.00, 0.20, 0.34, 0.52, 0.63);
   }
}

class Program
{
   static void Main()
   {
      GlobalTemp gt = new GlobalTemp();
      var tdVTuple = gt.TempDifferenceUsingValueTupleCtor();
      Console.WriteLine( "Temp increase 1950's to 2000: {0}C.", tdVTuple.d2000 );

      tdVTuple = gt.TempDifferenceUsingValueTuple();
      Console.WriteLine( "Temp increase 1950's to 2010: {0}C.", tdVTuple.d2010 );
   }
}
