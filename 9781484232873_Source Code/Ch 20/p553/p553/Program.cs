using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{
   static void Main()
   {
      XDocument employeeDoc =
         new XDocument(
            new XElement("Employees",
               new XElement("Employee",
               new XElement("Name", "Bob Smith"),
               new XElement("PhoneNumber", "408-555-1000")),
            new XElement("Employee",
               new XElement("Name", "Sally Jones"),
               new XElement("PhoneNumber", "415-555-2000"),
               new XElement("PhoneNumber", "415-555-2001"))
            )
         );

      XElement root = employeeDoc.Element("Employees");
      IEnumerable<XElement> employees = root.Elements();

      foreach (XElement emp in employees)
      {
         XElement empNameNode = emp.Element("Name");
         Console.WriteLine(empNameNode.Value);

         IEnumerable<XElement> empPhones = emp.Elements("PhoneNumber");
         foreach (XElement phone in empPhones)
            Console.WriteLine($"   { phone.Value }");
      }
   }
}