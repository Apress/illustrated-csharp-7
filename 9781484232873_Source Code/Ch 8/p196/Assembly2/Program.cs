// Source file name Assembly2.cs
using BaseClassNS;

namespace UsesBaseClass
{
   class DerivedClass : MyBaseClass
   {
      // Empty body
   }

   class Program
   {
      static void Main()
      {
         DerivedClass mdc = new DerivedClass();
         mdc.PrintMe();
      }
   }
}