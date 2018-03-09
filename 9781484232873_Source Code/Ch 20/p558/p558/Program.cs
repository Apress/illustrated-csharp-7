using System;
using System.Xml.Linq;

class Program
   {
      static void Main()
      {
         XDocument xd = new XDocument(
            new XElement("root",
               new XAttribute("color", "red"),
               new XAttribute("size", "large"),
               new XElement("first")
            )
         );

         XElement rt = xd.Element("root"); // Get the element.

         rt.Attribute("color").Remove(); // Remove the color attribute.
         rt.SetAttributeValue("size", null); // Remove the size attribute.

         Console.WriteLine(xd);
      }
   }
