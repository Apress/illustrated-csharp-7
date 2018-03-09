using System;

class Literals
{
   static void Main()
   {
      string rst1 = "Hi there!";
      string vst1 = @"Hi there!";
      string rst2 = "It started, \"Four score and seven...\"";
      string vst2 = @"It started, ""Four score and seven...""";
      string rst3 = "Value 1 \t 5, Val2 \t 10";             // Interprets tab esc sequence
      string vst3 = @"Value 1 \t 5, Val2 \t 10";            // Does not interpret tab
      string rst4 = "C:\\Program Files\\Microsoft\\";
      string vst4 = @"C:\Program Files\Microsoft\";
      string rst5 = " Print \x000A Multiple \u000A Lines";
      string vst5 = @" Print
 Multiple
 Lines";

      Console.WriteLine(rst1);
      Console.WriteLine(vst1);
      Console.WriteLine();

      Console.WriteLine(rst2);
      Console.WriteLine(vst2);
      Console.WriteLine();

      Console.WriteLine(rst3);
      Console.WriteLine(vst3);
      Console.WriteLine();

      Console.WriteLine(rst4);
      Console.WriteLine(vst4);
      Console.WriteLine();

      Console.WriteLine(rst5);
      Console.WriteLine();

      Console.WriteLine(vst5);
   }
}
