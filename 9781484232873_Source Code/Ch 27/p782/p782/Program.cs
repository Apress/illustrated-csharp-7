using System;
using System.Reflection;

class Program
{
   static void Main()
   {
      Console.WriteLine( "Enter a string to spell-check:" );
      string stringToSpellCheck = Console.ReadLine();
      string spellingResults;
      int errors = 0;

      if ( stringToSpellCheck.Length == 0 )
         spellingResults = "No string to check";
      else
      {
         Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
         Console.WriteLine( "\nChecking the string for misspellings ..." );
         app.Visible = false;

         Microsoft.Office.Interop.Word._Document tempDoc = app.Documents.Add();

         tempDoc.Words.First.InsertBefore( stringToSpellCheck );
         Microsoft.Office.Interop.Word.ProofreadingErrors spellErrorsColl = tempDoc.SpellingErrors;
         errors = spellErrorsColl.Count;

         // 1. Without using optional parameters
         // object ignoreCase    = true;
         // object alwaysSuggest = false;
         // object optional      = Missing.Value;
         // tempDoc.CheckSpelling( ref optional, ref ignoreCase, ref alwaysSuggest,
         //     ref optional, ref optional, ref optional, ref optional, ref optional,
         //     ref optional, ref optional, ref optional, ref optional );

         //2. Using the "omit ref" feature
         object optional = Missing.Value;
         tempDoc.CheckSpelling( optional, true, false, optional, optional, optional, optional, optional, optional, optional, optional, optional );

         //3. Using "omit ref" and optional parameters tempDoc.CheckSpelling( Missing.Value, true, false );
         app.Quit( false );
         spellingResults = errors + " errors found";
      }

      Console.WriteLine( spellingResults );
      Console.WriteLine( "\nPress <Enter> to exit program." );
      Console.ReadLine();
   }
}