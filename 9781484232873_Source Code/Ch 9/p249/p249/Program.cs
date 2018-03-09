using System;

class LimitedInt
{
   const int MaxValue = 100;
   const int MinValue = 0;

   public static implicit operator int(LimitedInt li)       // Convert type
   {
      return li.TheValue;
   }

   public static implicit operator LimitedInt(int x)        // Convert type
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
   static void Main()                                       // Main
   {
      LimitedInt li = 500;                                  // Convert 500 to LimitedInt
      int value = li;                                       // Convert LimitedInt to int
      Console.WriteLine($"li: { li.TheValue }, value: { value }");
   }
}