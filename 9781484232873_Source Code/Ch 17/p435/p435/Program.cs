using System;

class Program
   {
   static void Main()
   {
      int i = 10;
      object oi = i;

      int j = (int) oi;
      Console.WriteLine( $"i: { i },  oi: { oi },  j: { j }" );
   }
}

