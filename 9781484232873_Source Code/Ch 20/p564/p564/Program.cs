using System;
using System.Linq;
using System.Xml.Linq;

class Program
{
   static void Main()
   {
      XDocument xd = XDocument.Load("SimpleSample.xml");                // Load the document.
      XElement rt = xd.Element("MyElements");                           // Get the root element.

      var xyz = from e in rt.Elements()
                select new { e.Name, color = e.Attribute("color") };

      foreach (var x in xyz)
         Console.WriteLine(x);                                          // Default formatting
      Console.WriteLine();

      foreach (var x in xyz)
         Console.WriteLine("{0,-6}, color: {1, -7}", x.Name, x.color.Value);
   }
}
