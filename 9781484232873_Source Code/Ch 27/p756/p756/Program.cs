using System;

class Program
{
   static void Main()
   {
      string parseResultSummary;
      string stringFirst = "28";
      int intFirst;

      bool success = int.TryParse( stringFirst, out intFirst );

      parseResultSummary = success
                     ? "was successfully parsed"
                     : "was not successfully parsed";
      Console.WriteLine( $"String { stringFirst } { parseResultSummary }" );

      string stringSecond = "vt750";
      int intSecond;
      success = int.TryParse( stringSecond, out intSecond );

      parseResultSummary = success
                     ? "was successfully parsed"
                     : "was not successfully parsed";
      Console.WriteLine( $"String { stringSecond } { parseResultSummary }" );
   }
}
