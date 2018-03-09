using System;

class Program
{
   static void Main()
   {
      string s1 = "hi there! this, is: a string.";

      char[] delimiters = { ' ', '!', ',', ':', '.' };
      string[] words = s1.Split( delimiters, StringSplitOptions.RemoveEmptyEntries );

      Console.WriteLine( $"Word Count: { words.Length }\n\rThe Words..." );
      foreach ( string s in words )
         Console.WriteLine( $" { s }" );
   }
}
