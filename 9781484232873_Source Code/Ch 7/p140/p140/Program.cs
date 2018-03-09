using System;

class X
{
   public const double PI = 3.1416;
}

class Program
{
   static void Main()
   {
      Console.WriteLine( $"pi = { X.PI }" );    // Use the const field PI
   }
}