using System;
using System.Reflection;   // Use the Reflection namespace to take full advantage
                           // of determining information about a type.

class SomeClass
{
   public int Field1;
   public int Field2;
   public void Method1() { }
   public int  Method2() { return 1; }
}

class Program
{
   static void Main()
   {
      Type t = typeof(SomeClass);
      FieldInfo[] fi  = t.GetFields();
      MethodInfo[] mi = t.GetMethods();

      foreach (FieldInfo f in fi)
         Console.WriteLine($"Field : { f.Name }");
      foreach (MethodInfo m in mi)
         Console.WriteLine($"Method: { m.Name }");
   }
}