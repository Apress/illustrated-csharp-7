using System;

class D
{
   public int Mem1;
}

class Program
{
   static void Main()
   {
      D d1 = new D();
      D d2 = new D();

      d1.Mem1 = 10;
      d2.Mem1 = 28;

      Console.WriteLine( $"d1 = { d1.Mem1 }, d2 = { d2.Mem1 }" );
   }
}