using System;
using System.Collections;

class ColorEnumerator : IEnumerator
{
   string[] Colors;
   int Position = -1;

   public ColorEnumerator(string[] theColors) // Constructor
   {
      Colors = new string[theColors.Length];
      for (int i = 0; i < theColors.Length; i++)
         Colors[i] = theColors[i];
   }

   public object Current // Implement Current.
   {
      get
      {
         if (Position == -1)
            throw new InvalidOperationException();

         if (Position >= Colors.Length)
            throw new InvalidOperationException();

         return Colors[Position];
      }
   }

   public bool MoveNext() // Implement MoveNext.
   {
      if (Position < Colors.Length - 1)
      {
         Position++;
         return true;
      }
      else
         return false;
   }

   public void Reset() // Implement Reset.
   {
      Position = -1;
   }
}

class Spectrum : IEnumerable
{
   string[] Colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

   public IEnumerator GetEnumerator()
   {
      return new ColorEnumerator(Colors);
   }
}

class Program
{
   static void Main()
   {
      Spectrum spectrum = new Spectrum();
      foreach (string color in spectrum)
         Console.WriteLine(color);
   }
}