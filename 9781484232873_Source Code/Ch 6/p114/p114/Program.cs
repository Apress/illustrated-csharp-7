using System;

class Simple
{
   private int Score = 5;

   public ref int RefToValue()
   {
      return ref Score;
   }

   public void Display()
   {
      Console.WriteLine( $"Value inside class object: {Score}" );
   }
}
class Program
{
   static void Main()
   {
      Simple s = new Simple();
      s.Display();
      ref int v1Outside = ref s.RefToValue();

      v1Outside = 10;   // Change the value out in the calling scope.
      s.Display();      // Check that the value has changed.
   }
}