using System;

delegate void MyDelegate<T>(T value);                          // Generic delegate

class Simple
{
   static public void PrintString(string s)                    // Method matches delegate
   {
      Console.WriteLine(s);
   }

   static public void PrintUpperString(string s)               // Method matches delegate
   {
      Console.WriteLine($"{ s.ToUpper() }");
   }
}

class Program
{
   static void Main()
   {
      var myDel = new MyDelegate<string>(Simple.PrintString);  // Create inst of delegate.
      myDel += Simple.PrintUpperString;                        // Add a second method.

      myDel("Hi There.");                                      // Call delegate.
   }
}