using System;

class RightTriangle
{
   public double A = 3;
   public double B = 4;
   public double Hypotenuse                                 // Read-only property
   {
      get { return Math.Sqrt( ( A * A ) + ( B * B ) ); }    // Calculate return value
   }
}

class Program
{
   static void Main()
   {
      RightTriangle c = new RightTriangle();
      Console.WriteLine( $"Hypotenuse: { c.Hypotenuse }" );
   }
}