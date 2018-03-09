using static System.Console;

public struct MyType // Run twice; once as a struct and again as a class.
{
   public int X;
   public MyType(int x)
   {
      X = x;
   }
   public static MyType operator ++(MyType m)
   {
      m.X++;
      return m;
   }
}

class Test
{
   static void Show(string message, MyType tv)
   {
      WriteLine($"{message} {tv.X}");
   }
   static void Main()
   {
      MyType tv = new MyType(10);
      WriteLine("Pre-increment");
      Show("Before   ", tv);
      Show("Returned ", ++tv);
      Show("After    ", tv);
      WriteLine();

      tv = new MyType(10);
      WriteLine("Post-increment");
      Show("Before   ", tv);
      Show("Returned ", tv++);
      Show("After    ", tv);
   }
}