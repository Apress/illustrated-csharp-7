using System;

[Flags]
enum CardDeckSettings : uint
{
   SingleDeck    = 0x01,      // bit 0
   LargePictures = 0x02,      // bit 1
   FancyNumbers  = 0x04,      // bit 2
   Animation     = 0x08       // bit 3
}

class MyClass
{
   bool UseSingleDeck            = false,
   UseBigPics                    = false,
   UseFancyNumbers               = false,
   UseAnimation                  = false,
   UseAnimationAndFancyNumbers   = false;

   public void SetOptions(CardDeckSettings ops)
   {
      UseSingleDeck   = ops.HasFlag(CardDeckSettings.SingleDeck);
      UseBigPics      = ops.HasFlag(CardDeckSettings.LargePictures);
      UseFancyNumbers = ops.HasFlag(CardDeckSettings.FancyNumbers);
      UseAnimation    = ops.HasFlag(CardDeckSettings.Animation);

      CardDeckSettings testFlags =
                  CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
      UseAnimationAndFancyNumbers = ops.HasFlag(testFlags);
   }

   public void PrintOptions()
   {
      Console.WriteLine("Option settings:");
      Console.WriteLine($"  Use Single Deck                 - { UseSingleDeck }");
      Console.WriteLine($"  Use Large Pictures              - { UseBigPics }");
      Console.WriteLine($"  Use Fancy Numbers               - { UseFancyNumbers }");
      Console.WriteLine($"  Show Animation                  - { UseAnimation }");
      Console.WriteLine("  Show Animation and FancyNumbers – {0}", UseAnimationAndFancyNumbers);
   }
}

class Program
{
   static void Main()
   {
      MyClass mc = new MyClass();
      CardDeckSettings ops = CardDeckSettings.SingleDeck
                              | CardDeckSettings.FancyNumbers
                              | CardDeckSettings.Animation;
      mc.SetOptions(ops);
      mc.PrintOptions();
   }
}