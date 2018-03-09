using System;

class LimitedInt
{
   const int MaxValue = 100;
   const int MinValue = 0;

   public static explicit operator int(LimitedInt li)
   {
      return li.TheValue;
   }

   public static explicit operator LimitedInt(int x)
   {
      LimitedInt li = new LimitedInt();
      li.TheValue = x;
      return li;
   }

   private int mTheValue = 0;
   public int TheValue
   { // Property
      get { return mTheValue; }
      set
      {
         if (value < MinValue)
            mTheValue = 0;
         else
            mTheValue = value > MaxValue
                  ? MaxValue
                  : value;
      }
   }
}

class Program
{
   static void Main()
   {
      LimitedInt li = (LimitedInt)500;
      int value = (int)li;

      Console.WriteLine($"li: { li.TheValue }, value: { value }");
   }
}