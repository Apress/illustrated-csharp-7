using System;

class LimitedInt
{
   const int MaxValue = 100;
   const int MinValue = 0;

   public static LimitedInt operator -(LimitedInt x)
   {
      // In this strange class, negating a value just sets its value to 0.
      LimitedInt li = new LimitedInt();
      li.TheValue = 0;
      return li;
   }

   public static LimitedInt operator -(LimitedInt x, LimitedInt y)
   {
      LimitedInt li = new LimitedInt();
      li.TheValue = x.TheValue - y.TheValue;
      return li;
   }

   public static LimitedInt operator +(LimitedInt x, double y)
   {
      LimitedInt li = new LimitedInt();
      li.TheValue = x.TheValue + (int)y;
      return li;
   }

   private int _theValue = 0;
   public int TheValue
   {
      get { return _theValue; }
      set
      {
         if (value < MinValue)
            _theValue = 0;
         else
            _theValue = value > MaxValue
            ? MaxValue
            : value;
      }
   }
}

class Program
{
   static void Main()
   {
      LimitedInt li1 = new LimitedInt();
      LimitedInt li2 = new LimitedInt();
      LimitedInt li3 = new LimitedInt();

      li1.TheValue = 10; li2.TheValue = 26;
      Console.WriteLine($" li1: { li1.TheValue }, li2: { li2.TheValue }");

      li3 = -li1;
      Console.WriteLine($"-{ li1.TheValue } = { li3.TheValue }");

      li3 = li2 - li1;
      Console.WriteLine($" { li2.TheValue } - { li1.TheValue } = { li3.TheValue }");

      li3 = li1 - li2;
      Console.WriteLine($" { li1.TheValue } - { li2.TheValue } = { li3.TheValue }");
   }
}