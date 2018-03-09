using System;

class RandomNumberClass
{
   private static Random RandomKey;    // Private static field

   static RandomNumberClass()          // Static constructor
   {
      RandomKey = new Random();        // Initialize RandomKey
   }

   public int GetRandomNumber()
   {
      return RandomKey.Next();
   }
}

class Program
{
   static void Main()
   {
      RandomNumberClass a = new RandomNumberClass();
      RandomNumberClass b = new RandomNumberClass();

      Console.WriteLine( "Next Random #: {0}", a.GetRandomNumber() );
      Console.WriteLine( $"Next Random #: { b.GetRandomNumber() }" );
   }
}