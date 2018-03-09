using System;        // using DIRECTIVE; not using statement
using System.IO;     // using DIRECTIVE; not using statement

namespace UsingStatement
{
   class Program
   {
      static void Main()
      {
         // using statement
         using (TextWriter tw = File.CreateText("Lincoln.txt"))
         {
            tw.WriteLine("Four score and seven years ago, ...");
         }

         // using statement
         using (TextReader tr = File.OpenText("Lincoln.txt"))
         {
            string InputString;
            while (null != (InputString = tr.ReadLine()))
               Console.WriteLine(InputString);
         }
      }
   }
}