using System;

class Program
{
   static void Main( string[] args )
   {
      int? myI1, myI2, myI3;

      myI1 = 28;              // Value of underlying type
      myI2 = myI1;            // Value of nullable type
      myI3 = null;            // null

      Console.WriteLine( $"myI1: { myI1 }, myI2: { myI2 }, myI3: { myI3 }" );
   }
}
