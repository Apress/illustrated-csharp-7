using System;

class Program
{
   public static ref int PointerToHighestPositive( int[] numbers )
   {
      int highest        = 0;
      int indexOfHighest = 0;

      for ( int i = 0; i < numbers.Length; i++ )
      {
         if ( numbers[i] > highest )
         {
            indexOfHighest = i;
            highest        = numbers[indexOfHighest];
         }
      }
      return ref numbers[indexOfHighest];
   }

   static void Main()
   {
      int[] scores = { 5, 80 };
      Console.WriteLine( $"Before: {scores[0]}, {scores[1]}" );
      ref int locationOfHigher = ref PointerToHighestPositive( scores );

      locationOfHigher = 0;               // Change the value through ref local
      Console.WriteLine( $"After : {scores[0]}, {scores[1]}" );
   }
}