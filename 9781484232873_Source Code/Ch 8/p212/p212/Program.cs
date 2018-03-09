using System;

class MyData
{
   private double D1;                                 // Fields
   private double D2;
   private double D3;

   public MyData( double d1, double d2, double d3 )   // Constructor
   {
      D1 = d1;
      D2 = d2;
      D3 = d3;
   }

   public double Sum()                                // Method Sum
   {
      return D1 + D2 + D3;
   }
}

static class ExtendMyData
{
   public static double Average( MyData md )
   {
      return md.Sum() / 3;
   }
}

class Program
{
   static void Main()
   {
      MyData md = new MyData( 3, 4, 5 );
      Console.WriteLine( "Average: {0}", ExtendMyData.Average( md ) );
   }
}